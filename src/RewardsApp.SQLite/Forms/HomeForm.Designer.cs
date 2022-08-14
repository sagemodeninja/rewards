
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userJobTitleLbl = new System.Windows.Forms.Label();
            this.registerCustomerCell = new RewardsApp.SQLite.Forms.ActionableCell();
            this.addPointsCell = new RewardsApp.SQLite.Forms.ActionableCell();
            this.redeemPointsCell = new RewardsApp.SQLite.Forms.ActionableCell();
            this.actionableCell1 = new RewardsApp.SQLite.Forms.ActionableCell();
            this.optionsMenu.SuspendLayout();
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
            // registerCustomerCell
            // 
            this.registerCustomerCell.ActionKey = System.Windows.Forms.Keys.F1;
            this.registerCustomerCell.ActionText = "Register\r\nCustomer";
            this.registerCustomerCell.BackColor = System.Drawing.Color.Honeydew;
            this.registerCustomerCell.Location = new System.Drawing.Point(88, 57);
            this.registerCustomerCell.Name = "registerCustomerCell";
            this.registerCustomerCell.Size = new System.Drawing.Size(150, 136);
            this.registerCustomerCell.TabIndex = 11;
            this.registerCustomerCell.ActionInvoked += new System.EventHandler(this.RegisterCustomerCell_ActionInvoked);
            // 
            // addPointsCell
            // 
            this.addPointsCell.ActionKey = System.Windows.Forms.Keys.F5;
            this.addPointsCell.ActionText = "Add Points";
            this.addPointsCell.BackColor = System.Drawing.Color.Honeydew;
            this.addPointsCell.Location = new System.Drawing.Point(285, 57);
            this.addPointsCell.Name = "addPointsCell";
            this.addPointsCell.Size = new System.Drawing.Size(150, 136);
            this.addPointsCell.TabIndex = 12;
            this.addPointsCell.ActionInvoked += new System.EventHandler(this.AddPointsCell_ActionInvoked);
            // 
            // redeemPointsCell
            // 
            this.redeemPointsCell.ActionKey = System.Windows.Forms.Keys.F3;
            this.redeemPointsCell.ActionText = "Redeem\r\nPoints";
            this.redeemPointsCell.BackColor = System.Drawing.Color.Honeydew;
            this.redeemPointsCell.Location = new System.Drawing.Point(88, 213);
            this.redeemPointsCell.Name = "redeemPointsCell";
            this.redeemPointsCell.Size = new System.Drawing.Size(150, 136);
            this.redeemPointsCell.TabIndex = 13;
            this.redeemPointsCell.ActionInvoked += new System.EventHandler(this.RedeemPointsCell_ActionInvoked);
            // 
            // actionableCell1
            // 
            this.actionableCell1.ActionKey = System.Windows.Forms.Keys.F4;
            this.actionableCell1.ActionText = "Check\r\nPoints";
            this.actionableCell1.BackColor = System.Drawing.Color.Honeydew;
            this.actionableCell1.Location = new System.Drawing.Point(285, 213);
            this.actionableCell1.Name = "actionableCell1";
            this.actionableCell1.Size = new System.Drawing.Size(150, 136);
            this.actionableCell1.TabIndex = 14;
            this.actionableCell1.ActionInvoked += new System.EventHandler(this.CheckPointsCell_ActionInvoked);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 379);
            this.Controls.Add(this.actionableCell1);
            this.Controls.Add(this.redeemPointsCell);
            this.Controls.Add(this.addPointsCell);
            this.Controls.Add(this.registerCustomerCell);
            this.Controls.Add(this.userNameLbl);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.ContextMenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem cardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationMenuItem;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label userJobTitleLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private ActionableCell registerCustomerCell;
        private ActionableCell addPointsCell;
        private ActionableCell redeemPointsCell;
        private ActionableCell actionableCell1;
    }
}

