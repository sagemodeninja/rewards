namespace RewardsApp.SQLite.Forms
{
    partial class ActionableCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionTextLbl = new System.Windows.Forms.Label();
            this.actionKeyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionTextLbl
            // 
            this.actionTextLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTextLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionTextLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actionTextLbl.Location = new System.Drawing.Point(2, 68);
            this.actionTextLbl.Name = "actionTextLbl";
            this.actionTextLbl.Size = new System.Drawing.Size(146, 80);
            this.actionTextLbl.TabIndex = 3;
            this.actionTextLbl.Text = "Register Customer";
            this.actionTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionTextLbl.Click += new System.EventHandler(this.ActionLbl_Click);
            // 
            // actionKeyLbl
            // 
            this.actionKeyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionKeyLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionKeyLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actionKeyLbl.Location = new System.Drawing.Point(2, 2);
            this.actionKeyLbl.Name = "actionKeyLbl";
            this.actionKeyLbl.Size = new System.Drawing.Size(146, 62);
            this.actionKeyLbl.TabIndex = 2;
            this.actionKeyLbl.Text = "F1";
            this.actionKeyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionKeyLbl.Click += new System.EventHandler(this.ActionLbl_Click);
            // 
            // ActionableCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionTextLbl);
            this.Controls.Add(this.actionKeyLbl);
            this.Name = "ActionableCell";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionableCell_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label actionTextLbl;
        private System.Windows.Forms.Label actionKeyLbl;
    }
}
