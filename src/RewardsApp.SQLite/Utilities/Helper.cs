using Microsoft.Identity.Client;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RewardsApp.SQLite.Utilities
{
    public static class Helper
    {
        public static async Task<AuthenticationResult> SignInUserAndGetTokenUsingMsal(string[] scopes)
        {
            AuthenticationResult authResult;

            var accounts = await Program.PublicClientApp.GetAccountsAsync().ConfigureAwait(false);
            var firstAccount = accounts.FirstOrDefault();

            try
            {
                authResult = await Program.PublicClientApp.AcquireTokenSilent(scopes, firstAccount)
                                          .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                authResult = await Program.PublicClientApp.AcquireTokenInteractive(scopes)
                                          .WithUseEmbeddedWebView(true)
                                          .WithEmbeddedWebViewOptions(new EmbeddedWebViewOptions
                                          {
                                              Title = "Sign-in using Microsoft Account",
                                          })
                                          .ExecuteAsync();
            }

            return authResult;
        }

        public static string GetRootPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var rootPath = Path.Combine(appDataPath, "Shibumi Software", "Rewards App");

            // Creates root path if not exist.
            Directory.CreateDirectory(rootPath);

            return rootPath;
        }

        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Determines path to WebView2 cache file.
        /// </summary>
        /// <param name="cacheName">The filename for the cache.</param>
        /// <returns>The complete path of the cache file.</returns>
        public static string InitializeWebViewCacheFile(string cacheName)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appDirectory = Path.Combine(appDataPath, "Shibumi Software");

            Directory.CreateDirectory(appDirectory);

            return Path.Combine(appDirectory, $"{cacheName}.msalcache.bin3");
        }
    }
}
