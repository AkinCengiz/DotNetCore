namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Akýn CENGÝZ", "Serap CENGÝZ", "Bahtýnur CENGÝZ", "Cansu CENGÝZ" };
            btnRemoveOfStudents.Enabled = false;
            foreach (string student in students)
            {
                lbxStudents.Items.Add(student);
            }
        }

        private void btnAddToStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudent.Text != "")
            {
                students.Add(tbxStudent.Text);
                lbxStudents.Items.Clear();
                tbxStudent.Clear();
                tbxStudent.Focus();
                foreach (string student in students)
                {
                    lbxStudents.Items.Add(student);
                }
            }
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveOfStudents.Enabled = true;
        }

        private void btnRemoveOfStudents_Click(object sender, EventArgs e)
        {
            if (lbxStudents.SelectedItem != null)
            {
                students.Remove(lbxStudents.SelectedItem.ToString());
                lbxStudents.Items.Clear();
                foreach (string student in students)
                {
                    lbxStudents.Items.Add(student);
                }

                if (lbxStudents.Items.Count == 0)
                {
                    btnRemoveOfStudents.Enabled = false;
                }
            }
        }
    }
}