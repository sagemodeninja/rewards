namespace RewardsApp.SQLite.Forms.Editors
{
    partial class CardNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardNumberForm));
            this.keyboardShortcutsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumberTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // keyboardShortcutsLbl
            // 
            this.keyboardShortcutsLbl.AutoSize = true;
            this.keyboardShortcutsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyboardShortcutsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.keyboardShortcutsLbl.Location = new System.Drawing.Point(104, 107);
            this.keyboardShortcutsLbl.Name = "keyboardShortcutsLbl";
            this.keyboardShortcutsLbl.Size = new System.Drawing.Size(216, 15);
            this.keyboardShortcutsLbl.TabIndex = 9;
            this.keyboardShortcutsLbl.Text = "Press Enter to continue or Esc to cancel.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card Number:";
            // 
            // cardNumberTxt
            // 
            this.cardNumberTxt.Location = new System.Drawing.Point(44, 55);
            this.cardNumberTxt.Name = "cardNumberTxt";
            this.cardNumberTxt.PlaceholderText = "Type card no. here...";
            this.cardNumberTxt.Size = new System.Drawing.Size(316, 23);
            this.cardNumberTxt.TabIndex = 8;
            this.cardNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTxt_KeyPress);
            // 
            // CardNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 151);
            this.Controls.Add(this.keyboardShortcutsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNumberTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Card Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyboardShortcutsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardNumberTxt;
    }
}