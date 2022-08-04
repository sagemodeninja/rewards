using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class LoginForm : Form
    {
        public string AuthenticationURI { get; set; }

        public string RedirectPath { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            InitializedAuthentication();

            loginWebView.Source = new Uri(AuthenticationURI);
        }

        private void InitializedAuthentication()
        {
            string tenant = "9d6991bc-f819-474b-b741-b7e5ba25b776";
            string responseType = "code";
            string clientId = "f0eb3c50-6869-43a5-bed7-d8f966f89d7a";
            string scope = "user.read offline_access";

            string authenticationServer = $"https://login.microsoftonline.com/{tenant}/oauth2/v2.0/authorize";
            string redirectURI = $"https://garyantier.com/apps/shibumi/nativeclient/redirect.php";

            AuthenticationURI = $"{authenticationServer}?client_id={clientId}&response_type={responseType}&redirect_uri={redirectURI}&scope={scope}&prompt=select_account";
            RedirectPath = $"/apps/shibumi/nativeclient/redirect.php";
        }

        private void LoginWebView_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            Uri source = loginWebView.Source;
            Dictionary<string, string> parameters = null;

            if (!string.IsNullOrEmpty(source.Query))
            {
                parameters = ParseFragment(source.Query, new char[] { '&', '?' });
            }

            if (source.AbsolutePath.Equals(RedirectPath))
            {
                if (parameters.ContainsKey("code"))
                {
                    HomeForm homeForm = new HomeForm(parameters["code"]);
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
            string[] pairs = queryString.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string pair in pairs)
            {
                string[] nameValaue = pair.Split(new char[] { '=' });
                parameters.Add(nameValaue[0], nameValaue[1]);
            }
            return parameters;
        }
    }
}
