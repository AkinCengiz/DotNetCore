namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = "FirstName1";
            student.lastName = "LastName1";
            student.Age = 22;
            student.Mail = "abc@def.com";

            Student student2 = new Student()
            {
                FirstName = "FirstName2",
                lastName = "LastName2",
                Age = 18,
                Mail = "xyz@xyz.com"
            };

            List<Student> students = new List<Student>()
                {student,student2};
            foreach (Student std in students)
            {
                lbxStudents.Items.Add(std.FirstName + " " + std.lastName);
            }

            dgrvStudents.DataSource = students;
        }
    }
}