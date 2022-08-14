using AgilityFramework.Http;
using AgilityFramework.Http.Exceptions;
using AgilityFramework.Http.Tokens;
using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Forms.Editors;
using RewardsApp.SQLite.Utilities;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Forms
{
    public partial class HomeForm : Form
    {
        private readonly string _authCode;

        private string _userJobTitle;

        public HomeForm(string authorizationCode)
        {
            InitializeComponent();
            _authCode = authorizationCode;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                var codeProvider = await RequestCodeTokenProviderAsync();
                await LoadProfileAsync(codeProvider);
                UnlockFeatures();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.ResponseContent);
            }
        }

        private async Task<AuthProvider> RequestCodeTokenProviderAsync()
        {
            const string authTenantId = "9d6991bc-f819-474b-b741-b7e5ba25b776";
            const string authClientId = "f0eb3c50-6869-43a5-bed7-d8f966f89d7a";
            var authClientSecret = HttpUtility.UrlEncode("2g_Zvy~.QnZzbNX.K24uE36V~n529Z13.O");

            var authEndpoint = $"https://login.microsoftonline.com/{authTenantId}/oauth2/v2.0/token";
            var authRedirectUri = $"https://garyantier.com/apps/shibumi/nativeclient/redirect.php";

            AuthorizationCodeCredentials credentials = new(authClientId, authClientSecret, _authCode, authRedirectUri);
            credentials.AddScopes("User.Read");

            AuthProvider provider = new(authEndpoint, credentials);
            await provider.RequestAccessTokenAsync();

            return provider;
        }

        private async Task LoadProfileAsync(AuthProvider authProvider)
        {
            HttpContent content = new()
            {
                AuthProvider = authProvider
            };

            var user = await HTTPRequest.GetAsync<GraphUser>("https://graph.microsoft.com/v1.0/me/", content);

            _userJobTitle = user.JobTitle.Replace(' ', '.').ToLower();
            userNameLbl.Text = user.DisplayName;
            userJobTitleLbl.Text = user.JobTitle;
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
            MessageBox.Show("Feature not supported yet!");
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.M)) 
                ShowOptions();

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
