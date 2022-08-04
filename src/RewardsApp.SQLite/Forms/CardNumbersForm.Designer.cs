
namespace RewardsApp.SQLite.Forms
{
    partial class CardNumbersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardNumbersForm));
            this.cardsDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNumberBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDGV)).BeginInit();
            this.rowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardsDGV
            // 
            this.cardsDGV.AllowUserToAddRows = false;
            this.cardsDGV.AllowUserToDeleteRows = false;
            this.cardsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cardsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cardsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.Taken,
            this.Owner});
            this.cardsDGV.ContextMenuStrip = this.rowContextMenu;
            this.cardsDGV.Location = new System.Drawing.Point(12, 54);
            this.cardsDGV.MultiSelect = false;
            this.cardsDGV.Name = "cardsDGV";
            this.cardsDGV.ReadOnly = true;
            this.cardsDGV.RowHeadersVisible = false;
            this.cardsDGV.RowTemplate.Height = 25;
            this.cardsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cardsDGV.Size = new System.Drawing.Size(1153, 494);
            this.cardsDGV.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Taken
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Taken.DefaultCellStyle = dataGridViewCellStyle2;
            this.Taken.HeaderText = "Taken";
            this.Taken.Name = "Taken";
            this.Taken.ReadOnly = true;
            this.Taken.Width = 50;
            // 
            // Owner
            // 
            this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // rowContextMenu
            // 
            this.rowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.deleteMenuItem});
            this.rowContextMenu.Name = "rowContextMenu";
            this.rowContextMenu.ShowImageMargin = false;
            this.rowContextMenu.Size = new System.Drawing.Size(83, 48);
            this.rowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.RowContextMenu_Opening);
            this.rowContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RowContextMenu_ItemClicked);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(82, 22);
            this.editMenuItem.Text = "&Edit";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(82, 22);
            this.deleteMenuItem.Text = "&Delete";
            // 
            // addNumberBtn
            // 
            this.addNumberBtn.AutoSize = true;
            this.addNumberBtn.Location = new System.Drawing.Point(963, 12);
            this.addNumberBtn.Name = "addNumberBtn";
            this.addNumberBtn.Size = new System.Drawing.Size(121, 25);
            this.addNumberBtn.TabIndex = 1;
            this.addNumberBtn.Text = "Add Number";
            this.addNumberBtn.UseVisualStyleBackColor = true;
            this.addNumberBtn.Click += new System.EventHandler(this.AddNumberBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.Location = new System.Drawing.Point(1090, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 25);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CardNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 560);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addNumberBtn);
            this.Controls.Add(this.cardsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardNumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Card Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.cardsDGV)).EndInit();
            this.rowContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cardsDGV;
        private System.Windows.Forms.Button addNumberBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ContextMenuStrip rowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
    }
}