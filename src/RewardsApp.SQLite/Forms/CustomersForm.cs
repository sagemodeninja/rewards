using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Forms.Editors;
using RewardsApp.SQLite.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Diagnostics;

namespace RewardsApp.SQLite.Forms
{
    public partial class CustomersForm : Form
    {
        private List<Customer> _customers;

        public CustomersForm()
        {
            InitializeComponent();
            orderByCbo.SelectedIndex = 0;
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            _customers = await Customer.GetAll();

            _customers = orderByCbo.SelectedIndex == 1
                ? _customers.OrderBy(customer => $"{customer.LastName}, {customer.FirstName}".Trim()).ToList()
                : _customers.OrderBy(customer => customer.Card.Number).ToList();

            customersDGV.Rows.Clear();
            _customers.ForEach(AddRow);
        }

        private void AddRow(Customer customer)
        {
            var rowIndex = customersDGV.Rows.Add();
            var cells = customersDGV.Rows[rowIndex].Cells;

            PopulateCells(customer, cells);
        }

        private static void PopulateCells(Customer customer, DataGridViewCellCollection cells)
        {
            var card = customer.Card;
            var referrer = customer.Referrer;
            
            var singaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTime? localLastRedeemed = customer.LastRedeemed != null ? TimeZoneInfo.ConvertTimeFromUtc((DateTime)customer.LastRedeemed, singaporeTimeZone) : null;
            
            cells[0].Value = customer.Id;
            cells[1].Value = card.Number;
            cells[2].Value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase($"{customer.LastName}, {customer.FirstName}".ToLower());
            cells[3].Value = customer.Birthdate.ToString("MMM. dd, yyyy");
            cells[4].Value = customer.ContactNumber;
            cells[5].Value = customer.Email;
            cells[6].Value = referrer is null ? "None" : $"{referrer.LastName}, {referrer.FirstName}";
            cells[7].Value = customer.Points.ToString("#,##0.00");
            cells[8].Value = customer.LastRedeemedPoints.ToString("#,##0.00");
            cells[9].Value = localLastRedeemed?.ToString("MMM. dd, yyyy hh:mm tt");
        }

        private void RowContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var row = customersDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int) cells[0].Value;
            var customer = _customers.FirstOrDefault(c => c.Id == id);

            if(customer is null) return;

            var hasPoints = customer.Points > 0;

            redeemMenuItem.Enabled = hasPoints;
            resetMenuItem.Enabled = hasPoints;
            deleteMenuItem.Enabled = customer.Points == 0;
        }

        private async void RowContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuItem = e.ClickedItem;
            var row = customersDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int)cells[0].Value;
            var customer = _customers.FirstOrDefault(c => c.Id == id);

            if(customer is null) return;

            if (menuItem == redeemMenuItem)
            {
                RedeemPointsEditorForm editor = new(customer);

                editor.OnRedeemed(c => {
                    customer = c;

                    var singaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
                    DateTime? localLastRedeemed = customer.LastRedeemed != null ? TimeZoneInfo.ConvertTimeFromUtc((DateTime)customer.LastRedeemed, singaporeTimeZone) : null;

                    cells[7].Value = customer.Points.ToString("#,##0.00");
                    cells[8].Value = customer.LastRedeemedPoints.ToString("#,##0.00");
                    cells[9].Value = localLastRedeemed?.ToString("MMM. dd, yyyy hh:mm tt");
                });

                editor.ShowDialog();
            }
            else if (menuItem == editMenuItem)
            {
                CustomerEditorForm editor = new(customer);
                editor.OnEdited(c => PopulateCells(c, cells));
                editor.ShowDialog();
            }
            else if (menuItem == deleteMenuItem)
            {
                var response = MessageBox.Show(
                    $"You are about to delete {customer.LastName}, {customer.FirstName}!\nContinue?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (response != DialogResult.Yes) return;

                await customer.Delete();
                _customers.Remove(customer);
                customersDGV.Rows.Remove(row);
            }
            else if (menuItem == resetMenuItem)
            {
                var response = MessageBox.Show(
                    $"You are about to reset {customer.LastName}, {customer.FirstName}'s points!\nContinue?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (response != DialogResult.Yes) return;

                RedeemOverrideEditorForm overrideEditor = new();
                var result = overrideEditor.ShowOverride();

                if (result == PromptResult.Success)
                {
                    await customer.Reset();
                    PopulateCells(customer, cells);
                }
                else
                {
                    MessageBox.Show("Override failed!\n");
                }
            }
            else if (menuItem == transactionMenuItem)
            {
                var transactionForm = new TransactionForm(id);
                transactionForm.ShowDialog();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            if (keyData == (Keys.Control | Keys.R))
            {
                RefreshBtn_Click(null, null);
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                DefaultExt = "xlsx",
                Filter = @"Excel Workbook (*.xlsx)|*.xlsx",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = $"Customers {DateTime.Now:yyyy_MM_dd_HH_mm}"
            };

            var result = saveFileDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            var excelFile = saveFileDialog.FileName;

            GenerateExcelReport(excelFile);
            Process.Start("explorer.exe", excelFile);
        }
        
        private void GenerateExcelReport(string filePath)
        {
            using var workbook = new XLWorkbook();

            workbook.Properties.Author = "Shibumi Software";
            workbook.Properties.Company = "Blissful Cafe Cebu";

            var worksheet = workbook.Worksheets.Add();

            // Headers...
            var headerRow = worksheet.Row(1);
            var columnCount = customersDGV.Columns.Count;
            var rowCount = customersDGV.Rows.Count;

            for (var index = 1; index < columnCount; index++)
            {
                var headerText = customersDGV.Columns[index].HeaderText;
                headerRow.Cell(index)
                         .SetValue(headerText)
                         .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                         .Font.SetBold(true);

                if (headerText.ToLower().Contains("no") || headerText.ToLower().Contains("date"))
                    worksheet.Column(index).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            }

            // Body
            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                var gridViewRow = customersDGV.Rows[rowIndex];
                // 2=Excel row is non-zero + offset for header.
                var excelRow = worksheet.Row(rowIndex + 2);

                for (var colIndex = 1; colIndex < columnCount; colIndex++)
                {
                    var value = gridViewRow.Cells[colIndex].Value;
                    var excelCell = excelRow.Cell(colIndex)
                                            .SetValue(value);

                    if (value?.GetType() == typeof(decimal))
                        excelCell.Style.NumberFormat.SetFormat("#,##0.00");
                }
            }

            worksheet.Columns().AdjustToContents();

            // Save Excel file...
            workbook.SaveAs(filePath);
        }
    }
}
