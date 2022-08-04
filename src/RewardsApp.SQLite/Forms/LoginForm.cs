using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class LoginForm : Form
    {
        private const string TENANT = "9d6991bc-f819-474b-b741-b7e5ba25b776";
        private const string RESPONSE_TYPE = "code";
        private const string CLIENT_ID = "f0eb3c50-6869-43a5-bed7-d8f966f89d7a";
        private const string SCOPE = "user.read offline_access";

        private string AuthenticationUri { get; set; }

        private string RedirectPath { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            InitializedAuthentication();

            loginWebView.Source = new Uri(AuthenticationUri);
        }

        private void InitializedAuthentication()
        {
            var authenticationServer = $"https://login.microsoftonline.com/{TENANT}/oauth2/v2.0/authorize";
            var redirectUri = $"https://garyantier.com/apps/shibumi/nativeclient/redirect.php";

            AuthenticationUri = $"{authenticationServer}?client_id={CLIENT_ID}&response_type={RESPONSE_TYPE}&redirect_uri={redirectUri}&scope={SCOPE}&prompt=select_account";
            RedirectPath = $"/apps/shibumi/nativeclient/redirect.php";
        }

        private void LoginWebView_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            var source = loginWebView.Source;
            Dictionary<string, string> parameters = null;

            if (!string.IsNullOrEmpty(source.Query))
            {
                parameters = ParseFragment(source.Query, new char[] { '&', '?' });
            }

            if (source.AbsolutePath.Equals(RedirectPath))
            {
                if (parameters.ContainsKey("code"))
                {
                    var homeForm = new HomeForm(parameters["code"]);
                    homeForm.Show();
                    this.Hide();
                }
                else if (parameters.ContainsKey("error_description"))
                {
                    //new LoginErrorDialog(parameters["error_description"]).Show();
                    MessageBox.Show(parameters["error_description"]);
                    this.Hide();
                }
            }
        }

        // Info: Reference: https://docs.microsoft.com/en-us/advertising/shopping-content/code-example-authentication-oauth.
        private Dictionary<string, string> ParseFragment(string queryString, char[] delimeters)
        {
            var parameters = new Dictionary<string, string>();
            var pairs = queryString.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in pairs)
            {
                var nameValaue = pair.Split(new char[] { '=' });
                parameters.Add(nameValaue[0], nameValaue[1]);
            }
            return parameters;
        }
    }
}
