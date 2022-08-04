using System.IO;
using System.Text;
using System.Text.Json;

namespace RewardsApp.SQLite.Utilities
{
    public class Configuration
    {
        public float PointsPercentage { get; set; }

        public float ReferrerPointsPercentage { get; set; }

        public decimal ReferralPoints { get; set; }

        public bool OverridePasswordSet { get; set; }

        public string OverridePassword { get; set; }

        public int OverridePasswordLength { get; set; }

        private static string GetFile()
        {
            return Path.Combine(Helper.GetRootPath(), "config.json");
        }

        public static Configuration Load()
        {
            Configuration configuration = new();

            string file = GetFile();
            if (File.Exists(file))
            {
                using FileStream stream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using StreamReader reader = new StreamReader(stream);

                string content = reader.ReadToEnd();
                configuration = JsonSerializer.Deserialize<Configuration>(content);
            }

            return configuration;
        }

        public void Save()
        {
            using FileStream stream = File.Open(GetFile(), FileMode.OpenOrCreate, FileAccess.Write);

            string configuration = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            byte[] bytes = Encoding.UTF8.GetBytes(configuration);

            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
