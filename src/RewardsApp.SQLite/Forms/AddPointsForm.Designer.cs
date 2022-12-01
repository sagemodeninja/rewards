namespace RewardsApp.SQLite.Forms
{
    partial class AddPointsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPointsForm));
            this.rewardStagePnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPointsTxt = new System.Windows.Forms.TextBox();
            this.earnedPointsTxt = new System.Windows.Forms.TextBox();
            this.percentageTxt = new System.Windows.Forms.TextBox();
            this.currentPointsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.rewardStagePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rewardStagePnl
            // 
            this.rewardStagePnl.Controls.Add(this.label6);
            this.rewardStagePnl.Controls.Add(this.totalPointsTxt);
            this.rewardStagePnl.Controls.Add(this.earnedPointsTxt);
            this.rewardStagePnl.Controls.Add(this.percentageTxt);
            this.rewardStagePnl.Controls.Add(this.currentPointsTxt);
            this.rewardStagePnl.Controls.Add(this.label5);
            this.rewardStagePnl.Controls.Add(this.label4);
            this.rewardStagePnl.Controls.Add(this.label3);
            this.rewardStagePnl.Controls.Add(this.label2);
            this.rewardStagePnl.Controls.Add(this.totalAmountLbl);
            this.rewardStagePnl.Controls.Add(this.totalAmountTxt);
            this.rewardStagePnl.Controls.Add(this.customerNameLbl);
            this.rewardStagePnl.Location = new System.Drawing.Point(36, 41);
            this.rewardStagePnl.Name = "rewardStagePnl";
            this.rewardStagePnl.Size = new System.Drawing.Size(456, 297);
            this.rewardStagePnl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(140, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Press Enter to save or Esc to cancel.";
            // 
            // totalPointsTxt
            // 
            this.totalPointsTxt.Location = new System.Drawing.Point(217, 253);
            this.totalPointsTxt.Name = "totalPointsTxt";
            this.totalPointsTxt.ReadOnly = true;
            this.totalPointsTxt.Size = new System.Drawing.Size(138, 23);
            this.totalPointsTxt.TabIndex = 14;
            this.totalPointsTxt.TabStop = false;
            this.totalPointsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // earnedPointsTxt
            // 
            this.earnedPointsTxt.Location = new System.Drawing.Point(217, 225);
            this.earnedPointsTxt.Name = "earnedPointsTxt";
            this.earnedPointsTxt.ReadOnly = true;
            this.earnedPointsTxt.Size = new System.Drawing.Size(138, 23);
            this.earnedPointsTxt.TabIndex = 13;
            this.earnedPointsTxt.TabStop = false;
            this.earnedPointsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percentageTxt
            // 
            this.percentageTxt.Location = new System.Drawing.Point(217, 198);
            this.percentageTxt.Name = "percentageTxt";
            this.percentageTxt.ReadOnly = true;
            this.percentageTxt.Size = new System.Drawing.Size(138, 23);
            this.percentageTxt.TabIndex = 12;
            this.percentageTxt.TabStop = false;
            this.percentageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentPointsTxt
            // 
            this.currentPointsTxt.Location = new System.Drawing.Point(217, 170);
            this.currentPointsTxt.Name = "currentPointsTxt";
            this.currentPointsTxt.ReadOnly = true;
            this.currentPointsTxt.Size = new System.Drawing.Size(138, 23);
            this.currentPointsTxt.TabIndex = 11;
            this.currentPointsTxt.TabStop = false;
            this.currentPointsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(80, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Percentage:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Points:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Earned Points:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAmountLbl.Location = new System.Drawing.Point(113, 82);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(85, 15);
            this.totalAmountLbl.TabIndex = 5;
            this.totalAmountLbl.Text = "Total Amount:";
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.Location = new System.Drawing.Point(114, 102);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.Size = new System.Drawing.Size(241, 23);
            this.totalAmountTxt.TabIndex = 4;
            this.totalAmountTxt.TextChanged += new System.EventHandler(this.TotalAmountTxt_TextChanged);
            this.totalAmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalAmountTxt_KeyPress);
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameLbl.BackColor = System.Drawing.Color.White;
            this.customerNameLbl.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(120)))), ((int)(((byte)(74)))));
            this.customerNameLbl.Location = new System.Drawing.Point(0, 0);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(456, 55);
            this.customerNameLbl.TabIndex = 6;
            this.customerNameLbl.Text = "+";
            this.customerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 379);
            this.Controls.Add(this.rewardStagePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPointsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Points";
            this.Load += new System.EventHandler(this.AddPointsForm_Load);
            this.rewardStagePnl.ResumeLayout(false);
            this.rewardStagePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rewardStagePnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPointsTxt;
        private System.Windows.Forms.TextBox earnedPointsTxt;
        private System.Windows.Forms.TextBox percentageTxt;
        private System.Windows.Forms.TextBox currentPointsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.Label customerNameLbl;
    }
}