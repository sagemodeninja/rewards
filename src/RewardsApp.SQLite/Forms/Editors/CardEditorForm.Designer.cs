
namespace RewardsApp.SQLite.Forms.Editors
{
    partial class CardEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardEditorForm));
            this.cardNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyboardShortcutsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardNumberTxt
            // 
            this.cardNumberTxt.Location = new System.Drawing.Point(42, 67);
            this.cardNumberTxt.Name = "cardNumberTxt";
            this.cardNumberTxt.PlaceholderText = "Type card number here...";
            this.cardNumberTxt.Size = new System.Drawing.Size(316, 23);
            this.cardNumberTxt.TabIndex = 2;
            this.cardNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Number:";
            // 
            // keyboardShortcutsLbl
            // 
            this.keyboardShortcutsLbl.AutoSize = true;
            this.keyboardShortcutsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keyboardShortcutsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.keyboardShortcutsLbl.Location = new System.Drawing.Point(102, 119);
            this.keyboardShortcutsLbl.Name = "keyboardShortcutsLbl";
            this.keyboardShortcutsLbl.Size = new System.Drawing.Size(189, 15);
            this.keyboardShortcutsLbl.TabIndex = 3;
            this.keyboardShortcutsLbl.Text = "Press Enter to add or Esc to cancel.";
            // 
            // CardEditorForm
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label keyboardShortcutsLbl;
    }
}