using RewardsApp.SQLite.Entities;
using System;
using System.Windows.Forms;
using RewardsApp.SQLite.Utilities.Enums;
using System.Media;

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class RedeemPointsEditorForm : Form
    {
        private readonly Customer _customer;

        private Action<Customer> _onRedeemedAction;

        public RedeemPointsEditorForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void RedeemPointsEditorForm_Load(object sender, EventArgs e)
        {
            customerNameLbl.Text = $"{_customer.LastName}, {_customer.FirstName}";
            currentPointsTxt.Text = _customer.Points.ToString("#,##0.00");
            remainingPointsTxt.Text = "0.00";
        }

        private void AmountTxt_TextChanged(object sender, EventArgs e)
        {
            var amountString = amountTxt.Text;
            amountTxt.MaxLength = 7;
            if (string.IsNullOrWhiteSpace(amountString))
                amountString = "0";

            var amount = decimal.Parse(amountString);

            if (amount > _customer.Points)
            {
                errorProvider1.SetError(amountTxt, "Amount should not be more than current points.");
                remainingPointsTxt.Text = "-";
                SystemSounds.Exclamation.Play();
                return;
            }
            
            if(amount <= 0)
            {
                errorProvider1.SetError(amountTxt, "Amount should be more than 0.");
                remainingPointsTxt.Text = "-";
                SystemSounds.Exclamation.Play();
                return;
            }

            errorProvider1.SetError(amountTxt, "");
            var remainingPoints = _customer.Points - amount;
            remainingPointsTxt.Text = remainingPoints.ToString("#,##0.00");
        }

        private async void AmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            try
            {
                var amount = decimal.Parse(amountTxt.Text);
                RedeemOverrideEditorForm overrideEditor = new();
                var result = overrideEditor.ShowOverride();

                if (result == PromptResult.Success)
                {
                    await _customer.RedeemPoints(amount);
                    _onRedeemedAction?.Invoke(_customer);
                    Close();
                }
                else
                {
                    MessageBox.Show("Override failed!\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void OnRedeemed(Action<Customer> action)
        {
            _onRedeemedAction = action;
        }
    }
}
