using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class ConfigurationsForm : Form
    {
        private readonly string _userJobTitle;
        private bool _isConfigurationLoaded;
        private IEnumerable<string> _pendingMigrations;
        private bool _migrationsAvailable;

        private Configuration Configuration { get; set; }

        public ConfigurationsForm(string userJobTitle)
        {
            InitializeComponent();
            _userJobTitle = userJobTitle;
            _isConfigurationLoaded = false;
            _migrationsAvailable = false;
        }

        private async void ConfigurationsForm_Load(object sender, EventArgs e)
        {
            UnlockFeatures();
            Configuration = Configuration.Load();

            pointPercentageNUD.Value = (decimal)Configuration.PointsPercentage;
            referrerPointPercentageNUD.Value = (decimal)Configuration.ReferrerPointsPercentage;
            referralPointsNUD.Value = Configuration.ReferralPoints;

            if (Configuration.OverridePasswordSet)
            {
                var dummyPassword = string.Empty.PadLeft(Configuration.OverridePasswordLength, '*');
                overridePasswordTxt.Text = dummyPassword;

                overridePasswordTxt.ReadOnly = true;
                setOverridePasswordBtn.Enabled = false;
            }

            _isConfigurationLoaded = true;

            // Admin settings...
            await CheckDatabaseMigrated();
        }

        private void UnlockFeatures()
        {
            switch(_userJobTitle)
            {
                case "application.admin":
                    createBackupBtn.Enabled = true;
                    restoreBackupBtn.Enabled = true;
                    overridePasswordTxt.Enabled = true;
                    setOverridePasswordBtn.Enabled = true;
                    break;
                case "administrator":
                    createBackupBtn.Enabled = true;
                    restoreBackupBtn.Enabled = true;
                    overridePasswordTxt.Enabled = true;
                    setOverridePasswordBtn.Enabled = true;
                    break;
                case "supervisor":
                    overridePasswordTxt.Enabled = true;
                    setOverridePasswordBtn.Enabled = true;
                    break;
            }
        }

        private async Task CheckDatabaseMigrated()
        {
            await using RewardsAppContext context = new();

            _pendingMigrations = await context.Database.GetPendingMigrationsAsync();
            _migrationsAvailable = _pendingMigrations.Any();

            var labelColor = _migrationsAvailable ? Color.DarkBlue : Color.DarkGreen;

            databaseStatusLbl.Text = _migrationsAvailable ? "Migrations available." : "Up-to-date.";
            databaseStatusLbl.ActiveLinkColor = labelColor;
            databaseStatusLbl.VisitedLinkColor = labelColor;
            databaseStatusLbl.LinkColor = labelColor;
            migrateDatabaseBtn.Enabled = _migrationsAvailable;
        }

        private void PointPercentageNUD_ValueChanged(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void ReferrerPointPercentageNUD_ValueChanged(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void ReferralPointsNUD_ValueChanged(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void SaveConfiguration()
        {
            if (!_isConfigurationLoaded)
                return;

            try
            {
                Configuration.PointsPercentage = (float)pointPercentageNUD.Value;
                Configuration.ReferrerPointsPercentage = (float)referrerPointPercentageNUD.Value;
                Configuration.ReferralPoints = referralPointsNUD.Value;
                Configuration.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetOverridePasswordBtn_Click(object sender, EventArgs e)
        {
            if(Configuration.OverridePasswordSet)
                return;

            var plainPassword = overridePasswordTxt.Text;

            Configuration.OverridePasswordSet = true;
            Configuration.OverridePasswordLength = plainPassword.Length;
            Configuration.OverridePassword = Helper.HashPassword(plainPassword);
            Configuration.Save();

            overridePasswordTxt.ReadOnly = true;
            setOverridePasswordBtn.Enabled = false;
        }

        private void DatabaseStatusLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_migrationsAvailable) return;

            var builder = new StringBuilder("Pending migrations:\n\n");

            foreach (var migration in _pendingMigrations)
            {
                builder.AppendLine(migration);
            }

            MessageBox.Show(builder.ToString());
        }

        private void EditDatabaseBtn_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(
                "Are you sure to apply migrations?", 
                "Apply Migrations", 
                MessageBoxButtons.OKCancel);

            if (response == DialogResult.Cancel)
                return;

            using RewardsAppContext context = new();
            context.Database.Migrate();

            databaseStatusLbl.Text = "Up-to-date.";
            databaseStatusLbl.ActiveLinkColor = Color.DarkGreen;
            databaseStatusLbl.VisitedLinkColor = Color.DarkGreen;
            databaseStatusLbl.LinkColor = Color.DarkGreen;
            migrateDatabaseBtn.Enabled = false;
        }

        private void CreateBackupBtn_Click(object sender, EventArgs e)
        {
            saveBackupFileDialog.OverwritePrompt = true;

            saveBackupFileDialog.FileName = $"{DateTime.Now:yyyy-MM-dd-HH-mm} Backup";
            saveBackupFileDialog.DefaultExt = "dbackup";
            saveBackupFileDialog.Filter = "Database backup files (*.dbackup)|*.dbackup";
            saveBackupFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var result = saveBackupFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                ZipFile.CreateFromDirectory(Helper.GetRootPath(), saveBackupFileDialog.FileName);
                MessageBox.Show("Successfully backed up!");
            }
        }

        private void RestoreBackupBtn_Click(object sender, EventArgs e)
        {
            openBackupFileDialog.FileName = "";
            openBackupFileDialog.Filter = "Database backup files (*.dbackup)|*.dbackup";
            openBackupFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var result = openBackupFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ZipFile.ExtractToDirectory(openBackupFileDialog.FileName, Helper.GetRootPath(), true);
                MessageBox.Show("Successfully restored!");
            }
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
    }
}
