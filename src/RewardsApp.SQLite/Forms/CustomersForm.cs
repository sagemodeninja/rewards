using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Forms.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class CustomersForm : Form
    {
        public List<Customer> Customers { get; private set; }

        public CustomersForm()
        {
            InitializeComponent();
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            Customers = await Customer.GetAll();

            customersDGV.Rows.Clear();
            Customers.ForEach(AddRow);
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

            cells[0].Value = customer.Id;
            cells[1].Value = $"{customer.LastName}, {customer.FirstName}";
            cells[2].Value = customer.Birthdate.ToString("MMM. dd, yyyy");
            cells[3].Value = customer.ContactNumber;
            cells[4].Value = customer.Email;
            cells[5].Value = card.Number;
            cells[6].Value = referrer is null ? "None" : $"{referrer.LastName}, {referrer.FirstName}";
            cells[7].Value = customer.Points.ToString("#,##0.00");
            cells[8].Value = customer.LastRedeemedPoints.ToString("#,##0.00");
            cells[9].Value = customer.LastRedeemed?.ToString("MMM. dd, yyyy hh:mm tt");
        }

        private void RowContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var row = customersDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int) cells[0].Value;
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            redeemMenuItem.Enabled = customer.Points > 0;
            deleteMenuItem.Enabled = customer.Points == 0;
        }

        private async void RowContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuItem = e.ClickedItem;
            var row = customersDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int)cells[0].Value;
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (menuItem == redeemMenuItem)
            {
                RedeemPointsEditorForm editor = new(customer);

                editor.OnRedeemed(c => {
                    customer = c;
                    cells[7].Value = customer.Points.ToString("#,##0.00");
                    cells[8].Value = customer.LastRedeemedPoints.ToString("#,##0.00");
                    cells[9].Value = customer.LastRedeemed?.ToString("MMM. dd, yyyy hh:mm tt");
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
                var response = MessageBox.Show($"You are about to delete {customer.LastName}, {customer.FirstName}!\nContinue?", "Confirm", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    await customer.Delete();
                    Customers.Remove(customer);
                    customersDGV.Rows.Remove(row);
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
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
