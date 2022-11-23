namespace Proje3Odev
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
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.tbxEmployeeCity = new System.Windows.Forms.TextBox();
            this.tbxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.tbxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeId = new System.Windows.Forms.TextBox();
            this.dgrwCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(12, 422);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(203, 23);
            this.btnEmployeeAdd.TabIndex = 13;
            this.btnEmployeeAdd.Text = "Add To Employee";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // tbxEmployeeCity
            // 
            this.tbxEmployeeCity.Location = new System.Drawing.Point(12, 393);
            this.tbxEmployeeCity.Name = "tbxEmployeeCity";
            this.tbxEmployeeCity.PlaceholderText = "City";
            this.tbxEmployeeCity.Size = new System.Drawing.Size(203, 23);
            this.tbxEmployeeCity.TabIndex = 12;
            // 
            // tbxEmployeeEmail
            // 
            this.tbxEmployeeEmail.Location = new System.Drawing.Point(12, 364);
            this.tbxEmployeeEmail.Name = "tbxEmployeeEmail";
            this.tbxEmployeeEmail.PlaceholderText = "E-Mail";
            this.tbxEmployeeEmail.Size = new System.Drawing.Size(203, 23);
            this.tbxEmployeeEmail.TabIndex = 11;
            // 
            // tbxEmployeeLastName
            // 
            this.tbxEmployeeLastName.Location = new System.Drawing.Point(12, 335);
            this.tbxEmployeeLastName.Name = "tbxEmployeeLastName";
            this.tbxEmployeeLastName.PlaceholderText = "Last Name";
            this.tbxEmployeeLastName.Size = new System.Drawing.Size(203, 23);
            this.tbxEmployeeLastName.TabIndex = 10;
            // 
            // tbxEmployeeFirstName
            // 
            this.tbxEmployeeFirstName.Location = new System.Drawing.Point(12, 306);
            this.tbxEmployeeFirstName.Name = "tbxEmployeeFirstName";
            this.tbxEmployeeFirstName.PlaceholderText = "First Name";
            this.tbxEmployeeFirstName.Size = new System.Drawing.Size(203, 23);
            this.tbxEmployeeFirstName.TabIndex = 9;
            // 
            // tbxEmployeeId
            // 
            this.tbxEmployeeId.Location = new System.Drawing.Point(12, 277);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.PlaceholderText = "Employee ID";
            this.tbxEmployeeId.Size = new System.Drawing.Size(203, 23);
            this.tbxEmployeeId.TabIndex = 8;
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
            this.dgrwCustomers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.tbxEmployeeCity);
            this.Controls.Add(this.tbxEmployeeEmail);
            this.Controls.Add(this.tbxEmployeeLastName);
            this.Controls.Add(this.tbxEmployeeFirstName);
            this.Controls.Add(this.tbxEmployeeId);
            this.Controls.Add(this.dgrwCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEmployeeAdd;
        private TextBox tbxEmployeeCity;
        private TextBox tbxEmployeeEmail;
        private TextBox tbxEmployeeLastName;
        private TextBox tbxEmployeeFirstName;
        private TextBox tbxEmployeeId;
        private DataGridView dgrwCustomers;
    }
}