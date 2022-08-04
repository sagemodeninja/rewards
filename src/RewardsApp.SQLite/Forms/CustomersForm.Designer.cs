
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRedeemedPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRedeemed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redeemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.rowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(1090, 12);
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
            this.FullName,
            this.Birthdate,
            this.ContactNumber,
            this.Email,
            this.CardNo,
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
            // Id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
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
            // CardNo
            // 
            this.CardNo.HeaderText = "Card No.";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
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
            // rowContextMenu
            // 
            this.rowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redeemMenuItem,
            this.editMenuItem,
            this.deleteMenuItem});
            this.rowContextMenu.Name = "rowContextMenu";
            this.rowContextMenu.ShowImageMargin = false;
            this.rowContextMenu.Size = new System.Drawing.Size(93, 70);
            this.rowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.RowContextMenu_Opening);
            this.rowContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RowContextMenu_ItemClicked);
            // 
            // redeemMenuItem
            // 
            this.redeemMenuItem.Name = "redeemMenuItem";
            this.redeemMenuItem.Size = new System.Drawing.Size(92, 22);
            this.redeemMenuItem.Text = "&Redeem";
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(92, 22);
            this.editMenuItem.Text = "&Edit";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(92, 22);
            this.deleteMenuItem.Text = "&Delete";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 560);
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

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.ContextMenuStrip rowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem redeemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRedeemedPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRedeemed;
    }
}