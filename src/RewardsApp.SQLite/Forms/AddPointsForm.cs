using RewardsApp.SQLite.Entities;
using System;
using System.Windows.Forms;
using RewardsApp.SQLite.Utilities;

// ReSharper disable LocalizableElement

namespace RewardsApp.SQLite.Forms
{
    public partial class AddPointsForm : Form
    {
        private readonly Customer _customer;
        private readonly Configuration _configuration;

        private decimal _earnedPoints;
        private decimal _referrerEarnedPoints;

        public AddPointsForm(Customer customer)
        {
            InitializeComponent();

            _customer = customer;
            _configuration = Configuration.Load();
        }

        private void AddPointsForm_Load(object sender, EventArgs e)
        {
            customerNameLbl.Text = $"{_customer.LastName}, {_customer.FirstName}";

            currentPointsTxt.Text = _customer.Points.ToString("#,##0.00");
            percentageTxt.Text = $"{_configuration.PointsPercentage:0.00}%";
            earnedPointsTxt.Text = "0.00";
            totalPointsTxt.Text = _customer.Points.ToString("#,##0.00");
            
            totalAmountTxt.Focus();
        }

        private void TotalAmountTxt_TextChanged(object sender, EventArgs e)
        {
            var totalAmountString = totalAmountTxt.Text;

            if (string.IsNullOrWhiteSpace(totalAmountString))
                totalAmountString = "0";

            var totalAmount = decimal.Parse(totalAmountString);
            _earnedPoints = totalAmount * ((decimal)_configuration.PointsPercentage / 100);
            _referrerEarnedPoints = totalAmount * ((decimal)_configuration.ReferrerPointsPercentage / 100);
            var totalPoints = _customer.Points + _earnedPoints;

            earnedPointsTxt.Text = _earnedPoints.ToString("#,##0.00");
            totalPointsTxt.Text = totalPoints.ToString("#,##0.00");
        }

        private async void TotalAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;

            try
            {
                await _customer.AddPoints(_earnedPoints);

                if (_customer.ReferrerId is not null)
                    await Customer.AddPoints(_customer.ReferrerId ?? 0, _referrerEarnedPoints);
                
                MessageBox.Show("Points added to customer.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys != Keys.None || keyData != Keys.Escape)
                return base.ProcessDialogKey(keyData);

            Close();
            return true;
        }
    }
}
