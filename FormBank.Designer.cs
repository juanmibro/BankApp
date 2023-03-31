namespace BankApp
{
    partial class FormBank
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
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Location = new System.Drawing.Point(202, 131);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(213, 81);
            this.btnShowCustomers.TabIndex = 0;
            this.btnShowCustomers.Text = "Manage Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.btnShowCustomers);
            this.Name = "FormBank";
            this.Text = "MyBank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCustomers;
    }
}