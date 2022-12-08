using AgilityFramework.Http.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using RewardsApp.SQLite.Classes;
using RewardsApp.SQLite.Forms;
using System;
using System.Windows.Forms;

namespace RewardsApp.SQLite
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            InitializeAuth();
            InitializeAuthProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreenForm());
        }

        public static IConfiguration Configuration { get; private set; }

        public static IPublicClientApplication PublicClientApp { get; private set; }

        public static IAuthorizationProvider GraphAuthorizationProvider { get; private set; }

        private static void InitializeAuth()
        {
            var tenant = Configuration.GetValue<string>("AAD_Tenant");
            var clientId = Configuration.GetValue<string>("AAD_ClientId");

            PublicClientApp = PublicClientApplicationBuilder.Create(clientId)
                                                            .WithAuthority(AzureCloudInstance.AzurePublic, tenant)
                                                            .WithRedirectUri(DefaultRedirectUri.Value)
                                                            .Build();

            TokenCacheHelper.EnableSerialization(PublicClientApp.UserTokenCache);
        }

        private static void InitializeAuthProvider()
        {
            GraphAuthorizationProvider = new MsalAuthenticationProvider(new[] { "User.Read" });
        }
    }
}
