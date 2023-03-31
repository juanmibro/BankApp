namespace BankApp
{
    partial class FormAccounts
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
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_accont_info = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listboxOperations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(316, 360);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(230, 48);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete selected account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(314, 143);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(232, 51);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add  Omni Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // listAccounts
            // 
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.ItemHeight = 25;
            this.listAccounts.Location = new System.Drawing.Point(28, 29);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(268, 379);
            this.listAccounts.TabIndex = 4;
            this.listAccounts.SelectedValueChanged += new System.EventHandler(this.listAccounts_SelectedValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(616, 28);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 25);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(616, 72);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(255, 31);
            this.textAmount.TabIndex = 9;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(616, 138);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(112, 34);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(759, 138);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(112, 34);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_accont_info);
            this.groupBox1.Location = new System.Drawing.Point(567, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account info";
            // 
            // lbl_accont_info
            // 
            this.lbl_accont_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_accont_info.Location = new System.Drawing.Point(6, 27);
            this.lbl_accont_info.Name = "lbl_accont_info";
            this.lbl_accont_info.Size = new System.Drawing.Size(336, 150);
            this.lbl_accont_info.TabIndex = 0;
            this.lbl_accont_info.Text = "Select a account";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "Add Investment Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add Everyday Account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listboxOperations
            // 
            this.listboxOperations.FormattingEnabled = true;
            this.listboxOperations.ItemHeight = 25;
            this.listboxOperations.Location = new System.Drawing.Point(28, 480);
            this.listboxOperations.Name = "listboxOperations";
            this.listboxOperations.Size = new System.Drawing.Size(887, 179);
            this.listboxOperations.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Operations for failed transactions";
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxOperations);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.listAccounts);
            this.Name = "FormAccounts";
            this.Text = "FormAccounts";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_accont_info;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listboxOperations;
        private System.Windows.Forms.Label label1;
    }
}