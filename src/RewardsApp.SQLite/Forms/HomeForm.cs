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

namespace RewardsApp.SQLite.Forms
{
    public partial class HomeForm : Form
    {
        private readonly string _authCode;

        private string _userJobTitle;

        private bool _isRewardStage;

        public Configuration Configuration { get; private set; }

        public Customer CurrentCustomer { get; private set; }

        public decimal EarnedPoints { get; private set; }

        public decimal ReferrerEarnedPoints { get; private set; }

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

            Configuration = Configuration.Load();
            cardNumberTxt.Focus();
            _isRewardStage = false;

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
            await provider.RequestTokenAsync();

            return provider;
        }

        private async Task LoadProfileAsync(AuthProvider authProvider)
        {
            HTTPContent content = new()
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
                    cardNumberTxt.Enabled = true;
                    break;
                case "administrator":
                    cardMenuItem.Enabled = true;
                    customerMenuItem.Enabled = true;
                    configurationMenuItem.Enabled = true;
                    break;
                case "cashier":
                    cardMenuItem.Enabled = true;
                    customerMenuItem.Enabled = true;
                    cardNumberTxt.Enabled = true;
                    break;
            }
        }

        private async void CardNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            var cardNumber = cardNumberTxt.Text;
            var card = await Card.GetByNumber(cardNumber);

            if(card is null)
            {
                MessageBox.Show("Card not registered!");
                return;
            }

            var customer = card.Customer;
            if (customer is null)
            {
                CustomerEditorForm customerEditor = new(card);
                customerEditor.OnCreated(SwitchToRewardStage);
                customerEditor.ShowDialog();
                totalAmountTxt.Focus();
            }
            else
            {
                SwitchToRewardStage(customer);
            }
        }

        private void SwitchToRewardStage(Customer customer)
        {
            CurrentCustomer = customer;

            cardNumberStagePnl.Visible = false;
            customerNameLbl.Text = $"{customer.LastName}, {customer.FirstName}";

            currentPointsTxt.Text = customer.Points.ToString("#,##0.00");
            percentageTxt.Text = $"{Configuration.PointsPercentage:0.00}%";
            earnedPointsTxt.Text = "0.00";
            totalPointsTxt.Text = customer.Points.ToString("#,##0.00");

            rewardStagePnl.Visible = true;
            totalAmountTxt.Focus();

            _isRewardStage = true;
        }

        private void SwitchToCardNumberStage()
        {
            // Clear...
            cardNumberTxt.Clear();
            customerNameLbl.Text = "";
            currentPointsTxt.Clear();
            percentageTxt.Clear();
            earnedPointsTxt.Clear();
            totalAmountTxt.Clear();
            /**/
            rewardStagePnl.Visible = false;
            cardNumberStagePnl.Visible = true;
            cardNumberTxt.Focus();
            /**/
            CurrentCustomer = null;
            EarnedPoints = 0;
            /**/
            _isRewardStage = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape && _isRewardStage)
            {
                SwitchToCardNumberStage();
                return true;
            }

            if (keyData == (Keys.Alt| Keys.M))
            {
                ShowOptions();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void TotalAmountTxt_TextChanged(object sender, EventArgs e)
        {
            var totalAmountString = totalAmountTxt.Text;
            if (string.IsNullOrWhiteSpace(totalAmountString))
                totalAmountString = "0";

            var totalAmount = decimal.Parse(totalAmountString);
            EarnedPoints = totalAmount * ((decimal)Configuration.PointsPercentage / 100);
            ReferrerEarnedPoints = totalAmount * ((decimal)Configuration.ReferrerPointsPercentage / 100);
            var totalPoints = CurrentCustomer.Points + EarnedPoints;

            earnedPointsTxt.Text = EarnedPoints.ToString("#,##0.00");
            totalPointsTxt.Text = totalPoints.ToString("#,##0.00");
        }

        private async void TotalAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            try
            {
                await CurrentCustomer.AddPoints(EarnedPoints);

                if(CurrentCustomer.ReferrerId is not null)
                    await Customer.AddPoints(CurrentCustomer.ReferrerId ?? 0, ReferrerEarnedPoints);

                SwitchToCardNumberStage();
                MessageBox.Show("Points added to customer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            var x = optionsMenu.Width - optionsBtn.Width;
            var y = optionsBtn.Height;

            optionsMenu.Show(optionsBtn, new Point(-x, y));
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

            if(form is null)
                return;

            form.ShowDialog();
            Configuration = Configuration.Load();
            SwitchToCardNumberStage();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
