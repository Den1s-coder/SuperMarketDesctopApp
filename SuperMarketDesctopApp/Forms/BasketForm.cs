using SuperMarketDesctopApp.Model.Classes;

namespace SuperMarketDesctopApp.Forms
{
    public partial class BasketForm : Form
    {
        private List<Product> Basket = new List<Product>();
        private List<Product> _products;
        private CashRegister _cashRegister;
        public BasketForm(List<Product> products, CashRegister cashRegister)
        {
            InitializeComponent();
            _products = products;
            _cashRegister = cashRegister;
            LoadProducts(_products);
        }

        private void LoadProducts(List<Product> products)
        {
            foreach (var product in products) 
            {
                listBox1.Items.Add(product); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product selectedProduct)
            {
                var existingProduct = Basket.FirstOrDefault(p => p.ProductId == selectedProduct.ProductId);
                if (existingProduct != null)
                {
                    existingProduct.AddQuantity();
                }
                else
                {
                    Basket.Add(selectedProduct);
                }

                listBox2.Items.Clear();
                foreach (var product in Basket)
                {
                    listBox2.Items.Add(product);
                }
            }
            else
            {
                MessageBox.Show("Виберіть товар для додавання.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Product selectedProduct)
            {
                Basket.Remove(selectedProduct);

                listBox2.Items.Clear();
                foreach (var product in Basket)
                {
                    listBox2.Items.Add(product);
                }
            }
            else
            {
                MessageBox.Show("Виберіть товар для видалення.");
            }
        }

        private bool IsWholesalePurchase()
        {
            foreach (var product in Basket)
            {
                if (product.Quantity <= 5)
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Basket.Count == 0)
            {
                MessageBox.Show("Кошик порожній. Додайте товари.");
                return;
            }

            if (IsWholesalePurchase())
            {
                var paymentForm = new BulkPaymentForm(Basket, _cashRegister); 
                paymentForm.ShowDialog();
            }
            else
            {
                var paymentForm = new RetailPaymentForm(Basket, _cashRegister); 
                paymentForm.ShowDialog();
            }
        }
    }
}
