using RewardsApp.SQLite.Entities;
using System;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class CheckPointsForm : Form
    {
        private readonly Customer _customer;

        public CheckPointsForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void CheckPointsForm_Load(object sender, EventArgs e)
        {
            customerNameLbl.Text = $"{_customer.LastName}, {_customer.FirstName}";
            currentPointsTxt.Text = _customer.Points.ToString("#,##0.00");
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
