namespace Project1Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string AddToCartButtonText = "Add To Aquarium";
            string ProductListLabelText = "Fishes";
            string RemoveFromCartButtonText = "Remove From Aquarium";
            string CardListlabelText = "Aquarium";
            btnRemoveToCart.Text = RemoveFromCartButtonText;
            btnAddToCart.Text = AddToCartButtonText;
            lblCart.Text = CardListlabelText;
            lblProducts.Text = ProductListLabelText;
            btnAddToCart.BackColor = Color.Green;
            btnAddToCart.ForeColor = Color.White;
            btnRemoveToCart.BackColor = Color.Red;
            btnRemoveToCart.ForeColor = Color.White;
            string[] fishes = new string[6];
            fishes[0] = "Japon Balýðý";
            fishes[1] = "Ciklet Balýðý";
            fishes[2] = "Prenses Balýðý";
            fishes[3] = "Çöpçü Balýðý";
            fishes[4] = "Discus Balýðý";
            fishes[5] = "Melek Balýðý";

            foreach (string fish in fishes)
            {
                lbxProducts.Items.Add(fish);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false;
            }

            if (lbxProducts.SelectedItem == null)
            {
                btnAddToCart.Enabled = false;
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);
                btnAddToCart.Enabled = false;
            }
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToCart.Enabled = true;
            
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                btnRemoveToCart.Enabled = false;
            }
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveToCart.Enabled = true;
        }
    }
}