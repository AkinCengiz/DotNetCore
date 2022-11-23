namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Products";
            string cartText = "Cart";
            string addToCartButtonText = "Add To Cart";
            string removeToCartButtonText = "Remove To Cart";
            string[] products = new string[5];
            products[0] = "Laptop";
            products[1] = "Desktop";
            products[2] = "Mouse";
            products[3] = "Keyboard";
            products[4] = "Monitor";
            lblProducts.Text = productsText;
            lblCart.Text = cartText;
            btnAddToCart.Text = addToCartButtonText;
            btnRemoveToCart.Text = removeToCartButtonText;
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false;
            }
            for (int i = 0; i < products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);
            }
            foreach (string product in products)
            {
                lbxProducts.Items.Add(product);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //if (lbxProducts.SelectedItems.Count > 0)
            //{
            //    lbxCart.Items.Add(lbxProducts.SelectedItem);
            //}
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                if(btnRemoveToCart.Enabled==false)
                {
                    btnRemoveToCart.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Listeden sepete eklemek için ürün seçmediniz...","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.Items.Count > 0)
            {
                if (lbxCart.SelectedItem != null)
                {
                    lbxCart.Items.Remove(lbxCart.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Sepetten çýkarýlacak ürünü seçmediniz...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if(lbxCart.Items.Count==0)
            {
                btnRemoveToCart.Enabled = false;
            }
            
        }
    }
}