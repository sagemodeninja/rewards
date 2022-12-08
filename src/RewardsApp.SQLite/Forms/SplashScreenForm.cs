using Microsoft.Graph;
using RewardsApp.SQLite.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            CenterBranding();
        }

        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
            try
            {
                var authProvider = new CustomGraphAuthenticationProvider();
                var graphClient = new GraphServiceClient(authProvider);

                var user = await graphClient.Me.Request().GetAsync();
                var homeForm = new HomeForm(user);
                    homeForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Hide();
            }
        }

        private void CenterBranding()
        {
            var x = (ClientSize.Width - 100) / 2;
            var y = (ClientSize.Height - 100) / 2;

            branding.Location = new Point(x, y);
        }
    }
}
