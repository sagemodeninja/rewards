using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Forms.Editors;
using RewardsApp.SQLite.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

            _customers = orderByCbo.SelectedIndex == 0
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
            cells[1].Value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase($"{customer.LastName}, {customer.FirstName}".ToLower());
            cells[2].Value = customer.Birthdate.ToString("MMM. dd, yyyy");
            cells[3].Value = customer.ContactNumber;
            cells[4].Value = customer.Email;
            cells[5].Value = card.Number;
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

                if (result == RedeemOverrideResult.Success)
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
    }
}
