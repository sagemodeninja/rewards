using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RewardsApp.SQLite.Utilities
{
    public static class Helper
    {
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
    }
}
