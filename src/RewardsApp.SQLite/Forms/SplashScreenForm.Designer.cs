namespace RewardsApp.SQLite.Forms
{
    public partial class SplashScreenForm
    {
        private void InitializeComponent()
        {
            this.branding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.branding)).BeginInit();
            this.SuspendLayout();
            // 
            // branding
            // 
            this.branding.Image = global::RewardsApp.SQLite.Properties.Resources.blissful_logo;
            this.branding.Location = new System.Drawing.Point(0, 0);
            this.branding.Name = "branding";
            this.branding.Size = new System.Drawing.Size(100, 100);
            this.branding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.branding.TabIndex = 0;
            this.branding.TabStop = false;
            // 
            // SplashScreenForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 205);
            this.Controls.Add(this.branding);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branding)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox branding;
    }
}
