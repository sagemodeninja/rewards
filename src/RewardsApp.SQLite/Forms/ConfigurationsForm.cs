using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class ConfigurationsForm : Form
    {
        private readonly string _userJobTitle;

        private bool _isConfigurationLoaded;

        private bool _isDatabaseCreated;

        public Configuration Configuration { get; private set; }

        public ConfigurationsForm(string userJobTitle)
        {
            InitializeComponent();
            _userJobTitle = userJobTitle;
            _isConfigurationLoaded = false;
            _isDatabaseCreated = false;
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
                    editDatabaseBtn.Enabled = true;
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
            try
            {
                using RewardsAppContext context = new();
                Card cardCheck = await context.Cards.FirstOrDefaultAsync();

                _isDatabaseCreated = true;
                databaseStatusLbl.Text = "Created.";
                databaseStatusLbl.ForeColor = Color.DarkGreen;
                editDatabaseBtn.Text = "Reset Database";
            }
            catch
            {
                _isDatabaseCreated = false;
                databaseStatusLbl.Text = "Not Created.";
                databaseStatusLbl.ForeColor = Color.Red;
                editDatabaseBtn.Text = "Create Database";

                createBackupBtn.Enabled = false;
                restoreBackupBtn.Enabled = _userJobTitle == "application.admin";
            }
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

        private void EditDatabaseBtn_Click(object sender, EventArgs e)
        {
            editDatabaseBtn.Enabled = false;

            try
            {
                if(!_isDatabaseCreated)
                {
                    using RewardsAppContext context = new();
                    context.Database.Migrate();

                    _isDatabaseCreated = true;
                    databaseStatusLbl.Text = "Created.";
                    databaseStatusLbl.ForeColor = Color.DarkGreen;
                    editDatabaseBtn.Text = "Reset Database";

                    createBackupBtn.Enabled = true;
                    restoreBackupBtn.Enabled = false;
                }
                else
                {
                    var dbFile = Path.Combine(Helper.GetRootPath(), "data.db");
                    File.Delete(dbFile);

                    using RewardsAppContext context = new();
                    context.Database.Migrate();

                    databaseStatusLbl.Text = "Reseted.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            editDatabaseBtn.Enabled = true;
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
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
