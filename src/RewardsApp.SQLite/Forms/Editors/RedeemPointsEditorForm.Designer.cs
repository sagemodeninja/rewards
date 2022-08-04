
namespace RewardsApp.SQLite.Forms.Editors
{
    partial class RedeemPointsEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedeemPointsEditorForm));
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.remainingPointsTxt = new System.Windows.Forms.TextBox();
            this.currentPointsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameLbl.BackColor = System.Drawing.Color.White;
            this.customerNameLbl.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(120)))), ((int)(((byte)(74)))));
            this.customerNameLbl.Location = new System.Drawing.Point(0, 44);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(404, 55);
            this.customerNameLbl.TabIndex = 7;
            this.customerNameLbl.Text = "+";
            this.customerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAmountLbl.Location = new System.Drawing.Point(89, 126);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(55, 15);
            this.totalAmountLbl.TabIndex = 9;
            this.totalAmountLbl.Text = "Amount:";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(90, 146);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.PlaceholderText = "Enter amount of points to redeem...";
            this.amountTxt.Size = new System.Drawing.Size(241, 23);
            this.amountTxt.TabIndex = 8;
            this.amountTxt.TextChanged += new System.EventHandler(this.AmountTxt_TextChanged);
            this.amountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTxt_KeyPress);
            // 
            // remainingPointsTxt
            // 
            this.remainingPointsTxt.Location = new System.Drawing.Point(182, 275);
            this.remainingPointsTxt.Name = "remainingPointsTxt";
            this.remainingPointsTxt.ReadOnly = true;
            this.remainingPointsTxt.Size = new System.Drawing.Size(138, 23);
            this.remainingPointsTxt.TabIndex = 19;
            this.remainingPointsTxt.TabStop = false;
            this.remainingPointsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentPointsTxt
            // 
            this.currentPointsTxt.Location = new System.Drawing.Point(182, 235);
            this.currentPointsTxt.Name = "currentPointsTxt";
            this.currentPointsTxt.ReadOnly = true;
            this.currentPointsTxt.Size = new System.Drawing.Size(138, 23);
            this.currentPointsTxt.TabIndex = 18;
            this.currentPointsTxt.TabStop = false;
            this.currentPointsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Remaining Points:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current Points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(101, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Press Enter to redeem or Esc to cancel.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RedeemPointsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainingPointsTxt);
            this.Controls.Add(this.currentPointsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalAmountLbl);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.customerNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedeemPointsEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Redeem Points";
            this.Load += new System.EventHandler(this.RedeemPointsEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox remainingPointsTxt;
        private System.Windows.Forms.TextBox currentPointsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}