
namespace RewardsApp.SQLite.Forms
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.optionsBtn = new System.Windows.Forms.Button();
            this.optionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.cardNumberStagePnl = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userJobTitleLbl = new System.Windows.Forms.Label();
            this.optionsMenu.SuspendLayout();
            this.cardNumberStagePnl.SuspendLayout();
            this.rewardStagePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsBtn.BackgroundImage = global::RewardsApp.SQLite.Properties.Resources.ic_fluent_settings_28_filled;
            this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.optionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.optionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.Location = new System.Drawing.Point(488, 13);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.optionsBtn.Size = new System.Drawing.Size(24, 24);
            this.optionsBtn.TabIndex = 1;
            this.optionsBtn.TabStop = false;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // optionsMenu
            // 
            this.optionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardMenuItem,
            this.customerMenuItem,
            this.configurationMenuItem,
            this.aboutMenuItem});
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.ShowImageMargin = false;
            this.optionsMenu.Size = new System.Drawing.Size(127, 92);
            this.optionsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OptionsMenu_ItemClicked);
            // 
            // cardMenuItem
            // 
            this.cardMenuItem.Enabled = false;
            this.cardMenuItem.Name = "cardMenuItem";
            this.cardMenuItem.ShortcutKeyDisplayString = "";
            this.cardMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cardMenuItem.Text = "Card &Numbers";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Enabled = false;
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerMenuItem.Text = "&Customers";
            // 
            // configurationMenuItem
            // 
            this.configurationMenuItem.Enabled = false;
            this.configurationMenuItem.Name = "configurationMenuItem";
            this.configurationMenuItem.Size = new System.Drawing.Size(126, 22);
            this.configurationMenuItem.Text = "C&onfiguration";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Enabled = false;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutMenuItem.Text = "&About";
            // 
            // cardNumberTxt
            // 
            this.cardNumberTxt.Enabled = false;
            this.cardNumberTxt.Location = new System.Drawing.Point(14, 36);
            this.cardNumberTxt.Name = "cardNumberTxt";
            this.cardNumberTxt.PlaceholderText = "Input card number here...";
            this.cardNumberTxt.ShortcutsEnabled = false;
            this.cardNumberTxt.Size = new System.Drawing.Size(241, 23);
            this.cardNumberTxt.TabIndex = 2;
            this.cardNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card Number:";
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
            // cardNumberStagePnl
            // 
            this.cardNumberStagePnl.Controls.Add(this.label7);
            this.cardNumberStagePnl.Controls.Add(this.label1);
            this.cardNumberStagePnl.Controls.Add(this.cardNumberTxt);
            this.cardNumberStagePnl.Location = new System.Drawing.Point(125, 123);
            this.cardNumberStagePnl.Name = "cardNumberStagePnl";
            this.cardNumberStagePnl.Size = new System.Drawing.Size(270, 95);
            this.cardNumberStagePnl.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(74, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Press Enter to check.";
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
            this.rewardStagePnl.Location = new System.Drawing.Point(28, 43);
            this.rewardStagePnl.Name = "rewardStagePnl";
            this.rewardStagePnl.Size = new System.Drawing.Size(456, 297);
            this.rewardStagePnl.TabIndex = 8;
            this.rewardStagePnl.Visible = false;
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
            // userNameLbl
            // 
            this.userNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLbl.Location = new System.Drawing.Point(228, 5);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(250, 23);
            this.userNameLbl.TabIndex = 9;
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userJobTitleLbl
            // 
            this.userJobTitleLbl.Location = new System.Drawing.Point(228, 26);
            this.userJobTitleLbl.Name = "userJobTitleLbl";
            this.userJobTitleLbl.Size = new System.Drawing.Size(250, 15);
            this.userJobTitleLbl.TabIndex = 10;
            this.userJobTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 379);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.cardNumberStagePnl);
            this.Controls.Add(this.rewardStagePnl);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.userJobTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.optionsMenu.ResumeLayout(false);
            this.cardNumberStagePnl.ResumeLayout(false);
            this.cardNumberStagePnl.PerformLayout();
            this.rewardStagePnl.ResumeLayout(false);
            this.rewardStagePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.ContextMenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem cardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationMenuItem;
        private System.Windows.Forms.TextBox cardNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Panel cardNumberStagePnl;
        private System.Windows.Forms.Panel rewardStagePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentPointsTxt;
        private System.Windows.Forms.TextBox totalPointsTxt;
        private System.Windows.Forms.TextBox earnedPointsTxt;
        private System.Windows.Forms.TextBox percentageTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label userJobTitleLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    }
}

