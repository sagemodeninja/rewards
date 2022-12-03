using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Utilities;
using System;
using System.Windows.Forms;

// ReSharper disable LocalizableElement

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class CustomerEditorForm : Form
    {
        private readonly bool _isEdit;

        private readonly Card _card;

        private readonly Customer _customer;

        public Action<Customer> CustomerCreatedAction { get; private set; }

        public Action<Customer> CustomerEditedAction { get; private set; }

        private CustomerEditorForm() => InitializeComponent();

        public CustomerEditorForm(Card card) : this()
        {
            _isEdit = false;
            _card = card;
        }

        public CustomerEditorForm(Customer customer) : this()
        {
            _isEdit = true;
            _customer = customer;
        }

        private async void CustomerEditorForm_Load(object sender, EventArgs e)
        {
            // Load possible referrers...
            var customers = await Customer.GetAll();
            BindingSource binding = new();

            binding.DataSource = customers;
            referrerCbo.DataSource = binding;

            if (_isEdit)
            {
                referrerCbo.Enabled = false;

                cardNumberTxt.Text = _customer.Card.Number;
                referrerCbo.SelectedItem = _customer.Referrer;
                firstNameTxt.Text = _customer.FirstName;
                lastNameTxt.Text = _customer.LastName;
                birthDateDTP.Value = _customer.Birthdate;
                contactNumberTxt.Text = _customer.ContactNumber;
                emailTxt.Text = _customer.Email;

                Text = "Edit Customer";
                registerBtn.Text = "Save";
            }
            else
            {
                cardNumberTxt.Text = _card.Number;
            }
        }

        private void ReferrerCbo_Format(object sender, ListControlConvertEventArgs e)
        {
            var customer = (Customer)e.ListItem;
            e.Value = $"{customer.Card.Number} - {customer.LastName}, {customer.FirstName}";
        }

        private void EmailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 13)
                return;
            
            if(!_isEdit)
                RegisterCustomer();
            else
                UpdateCustomer();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!_isEdit)
                RegisterCustomer();
            else
                UpdateCustomer();
        }

        private async void RegisterCustomer()
        {
            try
            {
                var referrer = (Customer)referrerCbo.SelectedItem;
                Customer customer = new()
                {
                    CardId = _card.Id,
                    FirstName = firstNameTxt.Text,
                    LastName = lastNameTxt.Text,
                    Birthdate = birthDateDTP.Value,
                    ContactNumber = contactNumberTxt.Text,
                    Email = emailTxt.Text,
                    ReferrerId = referrer?.Id
                };
                await customer.Create();

                if(referrer is not null)
                {
                    var configuration = Configuration.Load();
                    await referrer.AddPoints(configuration.ReferralPoints);
                }

                CustomerCreatedAction?.Invoke(customer);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpdateCustomer()
        {
            _customer.FirstName = firstNameTxt.Text;
            _customer.LastName = lastNameTxt.Text;
            _customer.Birthdate = birthDateDTP.Value;
            _customer.ContactNumber = contactNumberTxt.Text;
            _customer.Email = emailTxt.Text;

            await _customer.Update();
            CustomerEditedAction.Invoke(_customer);
            Close();
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

        public void OnCreated(Action<Customer> action)
        {
            CustomerCreatedAction = action;
        }

        public void OnEdited(Action<Customer> action)
        {
            CustomerEditedAction = action;
        }
    }
}
