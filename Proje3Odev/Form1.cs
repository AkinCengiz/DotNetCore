using Project3Odev;

namespace Proje3Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EmployeeManager employeeManager = new EmployeeManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        public void LoadEmployee()
        {
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = employeeManager.GetAll();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Id = Convert.ToInt32(tbxEmployeeId.Text),
                FirstName = tbxEmployeeFirstName.Text,
                LastName = tbxEmployeeLastName.Text,
                Email = tbxEmployeeEmail.Text,
                City = tbxEmployeeCity.Text
            };
            employeeManager.Add(employee);
            Clear();
            LoadEmployee();

        }

        public void Clear()
        {
            tbxEmployeeCity.Clear();
            tbxEmployeeEmail.Clear();
            tbxEmployeeLastName.Clear();
            tbxEmployeeFirstName.Clear();
            tbxEmployeeId.Clear();
            tbxEmployeeId.Focus();
        }
    }
}