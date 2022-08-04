
namespace RewardsApp.SQLite.Forms.Editors
{
    partial class CustomerEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.cardNumberTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.referrerCbo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNumberTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(39, 131);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PlaceholderText = "First Name";
            this.firstNameTxt.Size = new System.Drawing.Size(211, 23);
            this.firstNameTxt.TabIndex = 2;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(279, 131);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PlaceholderText = "Last Name";
            this.lastNameTxt.Size = new System.Drawing.Size(211, 23);
            this.lastNameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(213, 292);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // cardNumberTxt
            // 
            this.cardNumberTxt.Location = new System.Drawing.Point(39, 58);
            this.cardNumberTxt.Name = "cardNumberTxt";
            this.cardNumberTxt.ReadOnly = true;
            this.cardNumberTxt.Size = new System.Drawing.Size(211, 23);
            this.cardNumberTxt.TabIndex = 6;
            this.cardNumberTxt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card Number:";
            // 
            // referrerCbo
            // 
            this.referrerCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.referrerCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.referrerCbo.FormattingEnabled = true;
            this.referrerCbo.Location = new System.Drawing.Point(279, 58);
            this.referrerCbo.Name = "referrerCbo";
            this.referrerCbo.Size = new System.Drawing.Size(211, 23);
            this.referrerCbo.TabIndex = 1;
            this.referrerCbo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ReferrerCbo_Format);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Referrer:";
            // 
            // birthDateDTP
            // 
            this.birthDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDTP.Location = new System.Drawing.Point(39, 206);
            this.birthDateDTP.Name = "birthDateDTP";
            this.birthDateDTP.Size = new System.Drawing.Size(124, 23);
            this.birthDateDTP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthdate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact No.:";
            // 
            // contactNumberTxt
            // 
            this.contactNumberTxt.Location = new System.Drawing.Point(181, 206);
            this.contactNumberTxt.Name = "contactNumberTxt";
            this.contactNumberTxt.PlaceholderText = "Contact Number";
            this.contactNumberTxt.Size = new System.Drawing.Size(145, 23);
            this.contactNumberTxt.TabIndex = 6;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(345, 206);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PlaceholderText = "Email Address";
            this.emailTxt.Size = new System.Drawing.Size(145, 23);
            this.emailTxt.TabIndex = 7;
            this.emailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // CustomerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 379);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contactNumberTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.referrerCbo);
            this.Controls.Add(this.cardNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustomerEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox cardNumberTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox referrerCbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDateDTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactNumberTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label7;
    }
}