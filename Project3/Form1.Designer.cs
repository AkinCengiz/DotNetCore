namespace Project3
{
    partial class Form1
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
            this.dgrwCustomers = new System.Windows.Forms.DataGridView();
            this.tbxCustomerId = new System.Windows.Forms.TextBox();
            this.tbxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.tbxCustomerLastName = new System.Windows.Forms.TextBox();
            this.tbxCustomerEmail = new System.Windows.Forms.TextBox();
            this.tbxCustomerCity = new System.Windows.Forms.TextBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwCustomers
            // 
            this.dgrwCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrwCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgrwCustomers.Name = "dgrwCustomers";
            this.dgrwCustomers.RowTemplate.Height = 25;
            this.dgrwCustomers.Size = new System.Drawing.Size(800, 265);
            this.dgrwCustomers.TabIndex = 0;
            // 
            // tbxCustomerId
            // 
            this.tbxCustomerId.Location = new System.Drawing.Point(12, 271);
            this.tbxCustomerId.Name = "tbxCustomerId";
            this.tbxCustomerId.PlaceholderText = "Customer ID";
            this.tbxCustomerId.Size = new System.Drawing.Size(203, 23);
            this.tbxCustomerId.TabIndex = 1;
            // 
            // tbxCustomerFirstName
            // 
            this.tbxCustomerFirstName.Location = new System.Drawing.Point(12, 300);
            this.tbxCustomerFirstName.Name = "tbxCustomerFirstName";
            this.tbxCustomerFirstName.PlaceholderText = "First Name";
            this.tbxCustomerFirstName.Size = new System.Drawing.Size(203, 23);
            this.tbxCustomerFirstName.TabIndex = 2;
            // 
            // tbxCustomerLastName
            // 
            this.tbxCustomerLastName.Location = new System.Drawing.Point(12, 329);
            this.tbxCustomerLastName.Name = "tbxCustomerLastName";
            this.tbxCustomerLastName.PlaceholderText = "Last Name";
            this.tbxCustomerLastName.Size = new System.Drawing.Size(203, 23);
            this.tbxCustomerLastName.TabIndex = 3;
            // 
            // tbxCustomerEmail
            // 
            this.tbxCustomerEmail.Location = new System.Drawing.Point(12, 358);
            this.tbxCustomerEmail.Name = "tbxCustomerEmail";
            this.tbxCustomerEmail.PlaceholderText = "E-Mail";
            this.tbxCustomerEmail.Size = new System.Drawing.Size(203, 23);
            this.tbxCustomerEmail.TabIndex = 4;
            // 
            // tbxCustomerCity
            // 
            this.tbxCustomerCity.Location = new System.Drawing.Point(12, 387);
            this.tbxCustomerCity.Name = "tbxCustomerCity";
            this.tbxCustomerCity.PlaceholderText = "City";
            this.tbxCustomerCity.Size = new System.Drawing.Size(203, 23);
            this.tbxCustomerCity.TabIndex = 5;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(12, 416);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(203, 23);
            this.btnCustomerAdd.TabIndex = 6;
            this.btnCustomerAdd.Text = "Add To Customer";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.tbxCustomerCity);
            this.Controls.Add(this.tbxCustomerEmail);
            this.Controls.Add(this.tbxCustomerLastName);
            this.Controls.Add(this.tbxCustomerFirstName);
            this.Controls.Add(this.tbxCustomerId);
            this.Controls.Add(this.dgrwCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxCustomerId;
        private TextBox tbxCustomerFirstName;
        private TextBox tbxCustomerLastName;
        private TextBox tbxCustomerEmail;
        private TextBox tbxCustomerCity;
        private Button btnCustomerAdd;
    }
}