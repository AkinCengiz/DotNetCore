namespace Project2
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblStudennName = new System.Windows.Forms.Label();
            this.tbxStudent = new System.Windows.Forms.TextBox();
            this.btnAddToStudent = new System.Windows.Forms.Button();
            this.btnRemoveOfStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 15;
            this.lbxStudents.Location = new System.Drawing.Point(12, 47);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(196, 289);
            this.lbxStudents.TabIndex = 0;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(12, 20);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(69, 15);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student List";
            // 
            // lblStudennName
            // 
            this.lblStudennName.AutoSize = true;
            this.lblStudennName.Location = new System.Drawing.Point(226, 20);
            this.lblStudennName.Name = "lblStudennName";
            this.lblStudennName.Size = new System.Drawing.Size(89, 15);
            this.lblStudennName.TabIndex = 2;
            this.lblStudennName.Text = "Student Name :";
            // 
            // tbxStudent
            // 
            this.tbxStudent.Location = new System.Drawing.Point(226, 47);
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.Size = new System.Drawing.Size(212, 23);
            this.tbxStudent.TabIndex = 3;
            // 
            // btnAddToStudent
            // 
            this.btnAddToStudent.Location = new System.Drawing.Point(332, 76);
            this.btnAddToStudent.Name = "btnAddToStudent";
            this.btnAddToStudent.Size = new System.Drawing.Size(106, 23);
            this.btnAddToStudent.TabIndex = 4;
            this.btnAddToStudent.Text = "Add To Student";
            this.btnAddToStudent.UseVisualStyleBackColor = true;
            this.btnAddToStudent.Click += new System.EventHandler(this.btnAddToStudent_Click);
            // 
            // btnRemoveOfStudents
            // 
            this.btnRemoveOfStudents.Location = new System.Drawing.Point(226, 289);
            this.btnRemoveOfStudents.Name = "btnRemoveOfStudents";
            this.btnRemoveOfStudents.Size = new System.Drawing.Size(75, 47);
            this.btnRemoveOfStudents.TabIndex = 5;
            this.btnRemoveOfStudents.Text = "Remove";
            this.btnRemoveOfStudents.UseVisualStyleBackColor = true;
            this.btnRemoveOfStudents.Click += new System.EventHandler(this.btnRemoveOfStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 358);
            this.Controls.Add(this.btnRemoveOfStudents);
            this.Controls.Add(this.btnAddToStudent);
            this.Controls.Add(this.tbxStudent);
            this.Controls.Add(this.lblStudennName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxStudents;
        private Label lblStudent;
        private Label lblStudennName;
        private TextBox tbxStudent;
        private Button btnAddToStudent;
        private Button btnRemoveOfStudents;
    }
}