
namespace RewardsApp.SQLite.Forms
{
    partial class ConfigurationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationsForm));
            this.editDatabaseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointPercentageNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.referrerPointPercentageNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseStatusLbl = new System.Windows.Forms.Label();
            this.saveBackupFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.createBackupBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.restoreBackupBtn = new System.Windows.Forms.Button();
            this.openBackupFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.referralPointsNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.overridePasswordTxt = new System.Windows.Forms.TextBox();
            this.setOverridePasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointPercentageNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referrerPointPercentageNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralPointsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // editDatabaseBtn
            // 
            this.editDatabaseBtn.AutoSize = true;
            this.editDatabaseBtn.Enabled = false;
            this.editDatabaseBtn.Location = new System.Drawing.Point(303, 262);
            this.editDatabaseBtn.Name = "editDatabaseBtn";
            this.editDatabaseBtn.Size = new System.Drawing.Size(109, 25);
            this.editDatabaseBtn.TabIndex = 4;
            this.editDatabaseBtn.Text = "Create Database";
            this.editDatabaseBtn.UseVisualStyleBackColor = true;
            this.editDatabaseBtn.Click += new System.EventHandler(this.EditDatabaseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point Percentage:";
            // 
            // pointPercentageNUD
            // 
            this.pointPercentageNUD.DecimalPlaces = 2;
            this.pointPercentageNUD.Location = new System.Drawing.Point(220, 41);
            this.pointPercentageNUD.Name = "pointPercentageNUD";
            this.pointPercentageNUD.Size = new System.Drawing.Size(58, 23);
            this.pointPercentageNUD.TabIndex = 1;
            this.pointPercentageNUD.ValueChanged += new System.EventHandler(this.PointPercentageNUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Referral Points:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Referrer Point Percentage:";
            // 
            // referrerPointPercentageNUD
            // 
            this.referrerPointPercentageNUD.DecimalPlaces = 2;
            this.referrerPointPercentageNUD.Location = new System.Drawing.Point(220, 77);
            this.referrerPointPercentageNUD.Name = "referrerPointPercentageNUD";
            this.referrerPointPercentageNUD.Size = new System.Drawing.Size(58, 23);
            this.referrerPointPercentageNUD.TabIndex = 2;
            this.referrerPointPercentageNUD.ValueChanged += new System.EventHandler(this.ReferrerPointPercentageNUD_ValueChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(38, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 2);
            this.label4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(128, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Section managed by Application Admin. or Administrator.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(116, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Database Status:";
            // 
            // databaseStatusLbl
            // 
            this.databaseStatusLbl.AutoSize = true;
            this.databaseStatusLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.databaseStatusLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.databaseStatusLbl.Location = new System.Drawing.Point(218, 267);
            this.databaseStatusLbl.Name = "databaseStatusLbl";
            this.databaseStatusLbl.Size = new System.Drawing.Size(73, 15);
            this.databaseStatusLbl.TabIndex = 25;
            this.databaseStatusLbl.Text = "Not Created.";
            // 
            // saveBackupFileDialog
            // 
            this.saveBackupFileDialog.DefaultExt = "db-backup";
            // 
            // createBackupBtn
            // 
            this.createBackupBtn.AutoSize = true;
            this.createBackupBtn.Enabled = false;
            this.createBackupBtn.Location = new System.Drawing.Point(220, 298);
            this.createBackupBtn.Name = "createBackupBtn";
            this.createBackupBtn.Size = new System.Drawing.Size(109, 25);
            this.createBackupBtn.TabIndex = 5;
            this.createBackupBtn.Text = "Create Backup";
            this.createBackupBtn.UseVisualStyleBackColor = true;
            this.createBackupBtn.Click += new System.EventHandler(this.CreateBackupBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(163, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Backup:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restoreBackupBtn
            // 
            this.restoreBackupBtn.AutoSize = true;
            this.restoreBackupBtn.Enabled = false;
            this.restoreBackupBtn.Location = new System.Drawing.Point(335, 297);
            this.restoreBackupBtn.Name = "restoreBackupBtn";
            this.restoreBackupBtn.Size = new System.Drawing.Size(109, 25);
            this.restoreBackupBtn.TabIndex = 6;
            this.restoreBackupBtn.Text = "Restore Backup";
            this.restoreBackupBtn.UseVisualStyleBackColor = true;
            this.restoreBackupBtn.Click += new System.EventHandler(this.RestoreBackupBtn_Click);
            // 
            // openBackupFileDialog
            // 
            this.openBackupFileDialog.FileName = "openFileDialog1";
            // 
            // referralPointsNUD
            // 
            this.referralPointsNUD.Location = new System.Drawing.Point(220, 114);
            this.referralPointsNUD.Name = "referralPointsNUD";
            this.referralPointsNUD.Size = new System.Drawing.Size(58, 23);
            this.referralPointsNUD.TabIndex = 3;
            this.referralPointsNUD.ValueChanged += new System.EventHandler(this.ReferralPointsNUD_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(100, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Override Password:";
            // 
            // overridePasswordTxt
            // 
            this.overridePasswordTxt.Enabled = false;
            this.overridePasswordTxt.Location = new System.Drawing.Point(220, 151);
            this.overridePasswordTxt.Name = "overridePasswordTxt";
            this.overridePasswordTxt.PlaceholderText = "Type password here...";
            this.overridePasswordTxt.Size = new System.Drawing.Size(144, 23);
            this.overridePasswordTxt.TabIndex = 29;
            this.overridePasswordTxt.UseSystemPasswordChar = true;
            // 
            // setOverridePasswordBtn
            // 
            this.setOverridePasswordBtn.AutoSize = true;
            this.setOverridePasswordBtn.Enabled = false;
            this.setOverridePasswordBtn.Location = new System.Drawing.Point(370, 149);
            this.setOverridePasswordBtn.Name = "setOverridePasswordBtn";
            this.setOverridePasswordBtn.Size = new System.Drawing.Size(109, 25);
            this.setOverridePasswordBtn.TabIndex = 30;
            this.setOverridePasswordBtn.Text = "Set Password";
            this.setOverridePasswordBtn.UseVisualStyleBackColor = true;
            this.setOverridePasswordBtn.Click += new System.EventHandler(this.SetOverridePasswordBtn_Click);
            // 
            // ConfigurationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 379);
            this.Controls.Add(this.setOverridePasswordBtn);
            this.Controls.Add(this.overridePasswordTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.referralPointsNUD);
            this.Controls.Add(this.restoreBackupBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createBackupBtn);
            this.Controls.Add(this.databaseStatusLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.referrerPointPercentageNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editDatabaseBtn);
            this.Controls.Add(this.pointPercentageNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.ConfigurationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointPercentageNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referrerPointPercentageNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralPointsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editDatabaseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pointPercentageNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown referrerPointPercentageNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label databaseStatusLbl;
        private System.Windows.Forms.SaveFileDialog saveBackupFileDialog;
        private System.Windows.Forms.Button createBackupBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button restoreBackupBtn;
        private System.Windows.Forms.OpenFileDialog openBackupFileDialog;
        private System.Windows.Forms.NumericUpDown referralPointsNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox overridePasswordTxt;
        private System.Windows.Forms.Button setOverridePasswordBtn;
    }
}