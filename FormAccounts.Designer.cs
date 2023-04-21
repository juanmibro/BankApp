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
            btnDeleteAccount = new System.Windows.Forms.Button();
            btnAddAccount = new System.Windows.Forms.Button();
            listAccounts = new System.Windows.Forms.ListBox();
            lblAmount = new System.Windows.Forms.Label();
            textAmount = new System.Windows.Forms.TextBox();
            btnDeposit = new System.Windows.Forms.Button();
            btnWithdraw = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lbl_accont_info = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            listboxOperations = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            btnTransfer = new System.Windows.Forms.Button();
            pnlTransfer = new System.Windows.Forms.Panel();
            btnDialogCancel = new System.Windows.Forms.Button();
            btnDialogAcept = new System.Windows.Forms.Button();
            textTransferAmount = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cbAccountTo = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cbAccountFrom = new System.Windows.Forms.ComboBox();
            groupBox1.SuspendLayout();
            pnlTransfer.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new System.Drawing.Point(639, 360);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new System.Drawing.Size(230, 48);
            btnDeleteAccount.TabIndex = 7;
            btnDeleteAccount.Text = "Delete selected account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new System.Drawing.Point(637, 143);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new System.Drawing.Size(232, 51);
            btnAddAccount.TabIndex = 5;
            btnAddAccount.Text = "Add  Omni Account";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // listAccounts
            // 
            listAccounts.FormattingEnabled = true;
            listAccounts.ItemHeight = 25;
            listAccounts.Location = new System.Drawing.Point(28, 29);
            listAccounts.Name = "listAccounts";
            listAccounts.Size = new System.Drawing.Size(603, 379);
            listAccounts.TabIndex = 4;
            listAccounts.SelectedValueChanged += listAccounts_SelectedValueChanged;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(943, 28);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(77, 25);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount";
            // 
            // textAmount
            // 
            textAmount.Location = new System.Drawing.Point(943, 72);
            textAmount.Name = "textAmount";
            textAmount.Size = new System.Drawing.Size(255, 31);
            textAmount.TabIndex = 9;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new System.Drawing.Point(943, 138);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new System.Drawing.Size(112, 34);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new System.Drawing.Point(1086, 138);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new System.Drawing.Size(112, 34);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_accont_info);
            groupBox1.Location = new System.Drawing.Point(894, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(348, 207);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account info";
            // 
            // lbl_accont_info
            // 
            lbl_accont_info.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_accont_info.Location = new System.Drawing.Point(6, 27);
            lbl_accont_info.Name = "lbl_accont_info";
            lbl_accont_info.Size = new System.Drawing.Size(336, 150);
            lbl_accont_info.TabIndex = 0;
            lbl_accont_info.Text = "Select a account";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(637, 86);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(232, 51);
            button3.TabIndex = 13;
            button3.Text = "Add Investment Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(637, 28);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(232, 51);
            button4.TabIndex = 14;
            button4.Text = "Add Everyday Account";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listboxOperations
            // 
            listboxOperations.FormattingEnabled = true;
            listboxOperations.ItemHeight = 25;
            listboxOperations.Location = new System.Drawing.Point(28, 480);
            listboxOperations.Name = "listboxOperations";
            listboxOperations.Size = new System.Drawing.Size(1214, 179);
            listboxOperations.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 452);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 25);
            label1.TabIndex = 16;
            label1.Text = "Operations for failed transactions";
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new System.Drawing.Point(637, 201);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new System.Drawing.Size(232, 48);
            btnTransfer.TabIndex = 17;
            btnTransfer.Text = "Transfer to account...";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // pnlTransfer
            // 
            pnlTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlTransfer.Controls.Add(btnDialogCancel);
            pnlTransfer.Controls.Add(btnDialogAcept);
            pnlTransfer.Controls.Add(textTransferAmount);
            pnlTransfer.Controls.Add(label4);
            pnlTransfer.Controls.Add(label3);
            pnlTransfer.Controls.Add(cbAccountTo);
            pnlTransfer.Controls.Add(label2);
            pnlTransfer.Controls.Add(cbAccountFrom);
            pnlTransfer.Location = new System.Drawing.Point(549, 301);
            pnlTransfer.Name = "pnlTransfer";
            pnlTransfer.Size = new System.Drawing.Size(726, 300);
            pnlTransfer.TabIndex = 18;
            pnlTransfer.Visible = false;
            // 
            // btnDialogCancel
            // 
            btnDialogCancel.Location = new System.Drawing.Point(470, 243);
            btnDialogCancel.Name = "btnDialogCancel";
            btnDialogCancel.Size = new System.Drawing.Size(112, 34);
            btnDialogCancel.TabIndex = 7;
            btnDialogCancel.Text = "Close";
            btnDialogCancel.UseVisualStyleBackColor = true;
            btnDialogCancel.Click += btnDialogCancel_Click;
            // 
            // btnDialogAcept
            // 
            btnDialogAcept.Location = new System.Drawing.Point(588, 243);
            btnDialogAcept.Name = "btnDialogAcept";
            btnDialogAcept.Size = new System.Drawing.Size(112, 34);
            btnDialogAcept.TabIndex = 6;
            btnDialogAcept.Text = "Transfer";
            btnDialogAcept.UseVisualStyleBackColor = true;
            btnDialogAcept.Click += btnDialogAcept_Click;
            // 
            // textTransferAmount
            // 
            textTransferAmount.Location = new System.Drawing.Point(18, 182);
            textTransferAmount.Name = "textTransferAmount";
            textTransferAmount.Size = new System.Drawing.Size(682, 31);
            textTransferAmount.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 25);
            label4.TabIndex = 4;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "To account";
            // 
            // cbAccountTo
            // 
            cbAccountTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAccountTo.FormattingEnabled = true;
            cbAccountTo.Location = new System.Drawing.Point(18, 113);
            cbAccountTo.Name = "cbAccountTo";
            cbAccountTo.Size = new System.Drawing.Size(682, 33);
            cbAccountTo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "Select from account";
            // 
            // cbAccountFrom
            // 
            cbAccountFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAccountFrom.FormattingEnabled = true;
            cbAccountFrom.Location = new System.Drawing.Point(18, 49);
            cbAccountFrom.Name = "cbAccountFrom";
            cbAccountFrom.Size = new System.Drawing.Size(682, 33);
            cbAccountFrom.TabIndex = 0;
            // 
            // FormAccounts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1383, 687);
            Controls.Add(pnlTransfer);
            Controls.Add(btnTransfer);
            Controls.Add(label1);
            Controls.Add(listboxOperations);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(textAmount);
            Controls.Add(lblAmount);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(listAccounts);
            Name = "FormAccounts";
            Text = "FormAccounts";
            FormClosing += FormAccounts_FormClosing;
            Load += FormAccounts_Load;
            groupBox1.ResumeLayout(false);
            pnlTransfer.ResumeLayout(false);
            pnlTransfer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Button btnDialogCancel;
        private System.Windows.Forms.Button btnDialogAcept;
        private System.Windows.Forms.TextBox textTransferAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAccountTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountFrom;
    }
}