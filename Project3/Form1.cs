namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Id = Convert.ToInt32(tbxCustomerId.Text),
                FirstName = tbxCustomerFirstName.Text,
                LastName = tbxCustomerLastName.Text,
                Email = tbxCustomerEmail.Text,
                City = tbxCustomerCity.Text
            };
            customerManager.Add(customer);
            LoadCustomers();    
            Clear();
        }

        public void Clear()
        {
            tbxCustomerCity.Clear();
            tbxCustomerEmail.Clear();
            tbxCustomerLastName.Clear();
            tbxCustomerFirstName.Clear();
            tbxCustomerId.Clear();
        }
    }
}