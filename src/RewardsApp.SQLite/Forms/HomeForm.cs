using AgilityFramework.Http.Exceptions;
using RewardsApp.SQLite.Forms.Editors;
using System;
using System.Drawing;
using System.Windows.Forms;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Forms
{
    public partial class HomeForm : Form
    {
        private string _userJobTitle;

        public HomeForm(Microsoft.Graph.User user)
        {
            InitializeComponent();
            
            _userJobTitle = user.JobTitle.Replace(' ', '.').ToLower();
            userNameLbl.Text = user.DisplayName;
            userJobTitleLbl.Text = user.JobTitle;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                UnlockFeatures();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.ResponseContent);
            }
        }

        private void UnlockFeatures()
        {
            switch(_userJobTitle)
            {
                case "application.admin":
                    cardMenuItem.Enabled = true;
                    customerMenuItem.Enabled = true;
                    configurationMenuItem.Enabled = true;
                    break;
                case "administrator":
                    cardMenuItem.Enabled = true;
                    customerMenuItem.Enabled = true;
                    configurationMenuItem.Enabled = true;
                    break;
                case "cashier":
                    cardMenuItem.Enabled = true;
                    customerMenuItem.Enabled = true;
                    break;
            }
        }

        private void RegisterCustomerCell_ActionInvoked(object sender, EventArgs e)
        {
            var prompt = new CardNumberForm();
            var result = prompt.ShowOverride();

            if(result == PromptResult.Failed) return;

            CustomerEditorForm customerEditor = new(prompt.SelectedCard);
            customerEditor.ShowDialog();
        }

        private void AddPointsCell_ActionInvoked(object sender, EventArgs e)
        {
            var prompt = new CardNumberForm();
            var result = prompt.ShowOverride();

            if (result == PromptResult.Failed) return;

            var card = prompt.SelectedCard;
            var customer = card.Customer;

            if (customer is null)
            {
                CustomerEditorForm customerEditor = new(card);
                customerEditor.OnCreated(newCustomer => customer = newCustomer);
                customerEditor.ShowDialog();
            }
            
            var addPointsForm = new AddPointsForm(customer);
            addPointsForm.ShowDialog();
        }

        private void RedeemPointsCell_ActionInvoked(object sender, EventArgs e)
        {
            var prompt = new CardNumberForm();
            var result = prompt.ShowOverride();

            if (result == PromptResult.Failed) return;

            var card = prompt.SelectedCard;
            var customer = card.Customer;

            RedeemPointsEditorForm editor = new(customer);
            editor.ShowDialog();
        }

        private void CheckPointsCell_ActionInvoked(object sender, EventArgs e)
        {
            var prompt = new CardNumberForm();
            var result = prompt.ShowOverride();

            if (result == PromptResult.Failed) return;

            var card = prompt.SelectedCard;
            var customer = card.Customer;

            if (customer is null)
            {
                CustomerEditorForm customerEditor = new(card);
                customerEditor.OnCreated(newCustomer => customer = newCustomer);
                customerEditor.ShowDialog();
            }

            var checkPointsForm = new CheckPointsForm(customer);
            checkPointsForm.ShowDialog();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.M)) 
                ShowOptions();

            switch(keyData)
            {
                case Keys.F1:
                    RegisterCustomerCell_ActionInvoked(null, null);
                    break;
                case Keys.F2:
                    AddPointsCell_ActionInvoked(null, null);
                    break;
                case Keys.F3:
                    RedeemPointsCell_ActionInvoked(null, null);
                    break;
                case Keys.F4:
                    CheckPointsCell_ActionInvoked(null, null);
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
            => ShowOptions();

        private void ShowOptions()
        {
            var x = optionsMenu.Width - optionsBtn.Width;
            var y = optionsBtn.Height;
            var menuPosition = new Point(-x, y);

            optionsMenu.Show(optionsBtn, menuPosition);
        }

        private void OptionsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuItem = e.ClickedItem;
            Form form = default;

            if (menuItem == cardMenuItem)
                form = new CardNumbersForm();

            if (menuItem == customerMenuItem)
                form = new CustomersForm();

            if (menuItem == configurationMenuItem)
                form = new ConfigurationsForm(_userJobTitle);

            if(form is null) return;

            form.ShowDialog();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
