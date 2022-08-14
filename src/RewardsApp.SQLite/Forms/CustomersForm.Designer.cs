
namespace RewardsApp.SQLite.Forms
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.refreshBtn = new System.Windows.Forms.Button();
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.rowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redeemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRedeemedPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRedeemed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.rowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(941, 15);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 25);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CardNo,
            this.FullName,
            this.Birthdate,
            this.ContactNumber,
            this.Email,
            this.Referrer,
            this.Points,
            this.LastRedeemedPoints,
            this.LastRedeemed});
            this.customersDGV.ContextMenuStrip = this.rowContextMenu;
            this.customersDGV.Location = new System.Drawing.Point(12, 54);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.ReadOnly = true;
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowTemplate.Height = 25;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(1153, 494);
            this.customersDGV.TabIndex = 1;
            // 
            // rowContextMenu
            // 
            this.rowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redeemMenuItem,
            this.editMenuItem,
            this.resetMenuItem,
            this.deleteMenuItem,
            this.transactionMenuItem});
            this.rowContextMenu.Name = "rowContextMenu";
            this.rowContextMenu.ShowImageMargin = false;
            this.rowContextMenu.Size = new System.Drawing.Size(143, 114);
            this.rowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.RowContextMenu_Opening);
            this.rowContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RowContextMenu_ItemClicked);
            // 
            // redeemMenuItem
            // 
            this.redeemMenuItem.Name = "redeemMenuItem";
            this.redeemMenuItem.Size = new System.Drawing.Size(142, 22);
            this.redeemMenuItem.Text = "&Redeem";
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editMenuItem.Text = "&Edit";
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(142, 22);
            this.resetMenuItem.Text = "Re&set";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteMenuItem.Text = "&Delete";
            // 
            // transactionMenuItem
            // 
            this.transactionMenuItem.Name = "transactionMenuItem";
            this.transactionMenuItem.Size = new System.Drawing.Size(142, 22);
            this.transactionMenuItem.Text = "View &Transactions";
            // 
            // orderByCbo
            // 
            this.orderByCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByCbo.FormattingEnabled = true;
            this.orderByCbo.Items.AddRange(new object[] {
            "Card No.",
            "Full Name"});
            this.orderByCbo.Location = new System.Drawing.Point(814, 17);
            this.orderByCbo.Name = "orderByCbo";
            this.orderByCbo.Size = new System.Drawing.Size(121, 23);
            this.orderByCbo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Right-click each item to show more options.";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Location = new System.Drawing.Point(1022, 16);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(142, 23);
            this.generateReportBtn.TabIndex = 25;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // Id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // CardNo
            // 
            this.CardNo.HeaderText = "Card No.";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Referrer
            // 
            this.Referrer.HeaderText = "Referrer";
            this.Referrer.Name = "Referrer";
            this.Referrer.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // LastRedeemedPoints
            // 
            this.LastRedeemedPoints.HeaderText = "Redeemed Points";
            this.LastRedeemedPoints.Name = "LastRedeemedPoints";
            this.LastRedeemedPoints.ReadOnly = true;
            this.LastRedeemedPoints.Width = 150;
            // 
            // LastRedeemed
            // 
            this.LastRedeemed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastRedeemed.HeaderText = "Last Redeemed";
            this.LastRedeemed.Name = "LastRedeemed";
            this.LastRedeemed.ReadOnly = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 560);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderByCbo);
            this.Controls.Add(this.customersDGV);
            this.Controls.Add(this.refreshBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.rowContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.ContextMenuStrip rowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem redeemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionMenuItem;
        private System.Windows.Forms.ComboBox orderByCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRedeemedPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRedeemed;
    }
}