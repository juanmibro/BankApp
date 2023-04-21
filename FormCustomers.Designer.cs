namespace BankApp
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class FormCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
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
            listCustomers = new System.Windows.Forms.ListBox();
            btnAddCustomer = new System.Windows.Forms.Button();
            btnEditCustomer = new System.Windows.Forms.Button();
            btnDeleteCustomer = new System.Windows.Forms.Button();
            textCustomerName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            textContactInfo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // listCustomers
            // 
            listCustomers.FormattingEnabled = true;
            listCustomers.ItemHeight = 25;
            listCustomers.Location = new System.Drawing.Point(31, 90);
            listCustomers.Name = "listCustomers";
            listCustomers.Size = new System.Drawing.Size(268, 379);
            listCustomers.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new System.Drawing.Point(313, 301);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new System.Drawing.Size(196, 74);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer (Staff)";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new System.Drawing.Point(313, 393);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new System.Drawing.Size(196, 76);
            btnEditCustomer.TabIndex = 2;
            btnEditCustomer.Text = "Edit Customer's Accounts";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new System.Drawing.Point(515, 398);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new System.Drawing.Size(196, 71);
            btnDeleteCustomer.TabIndex = 3;
            btnDeleteCustomer.Text = "Delete selected customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new System.Drawing.Point(334, 105);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new System.Drawing.Size(361, 31);
            textCustomerName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(334, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(153, 25);
            label1.TabIndex = 5;
            label1.Text = "Customer's Name";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(515, 301);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(196, 74);
            button1.TabIndex = 6;
            button1.Text = "Add Customer (Normal)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(334, 165);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 25);
            label2.TabIndex = 7;
            label2.Text = "Contact info";
            // 
            // textContactInfo
            // 
            textContactInfo.Location = new System.Drawing.Point(334, 193);
            textContactInfo.Name = "textContactInfo";
            textContactInfo.Size = new System.Drawing.Size(361, 31);
            textContactInfo.TabIndex = 8;
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(793, 562);
            Controls.Add(textContactInfo);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textCustomerName);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(listCustomers);
            Name = "FormCustomers";
            Text = "FormCustomers";
            FormClosing += FormCustomers_FormClosing;
            Load += FormCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textContactInfo;
    }
}