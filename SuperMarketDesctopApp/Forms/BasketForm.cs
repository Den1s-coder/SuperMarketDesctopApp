using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;

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

            foreach (var product in _products)
            {
                product.ProductOutOfStock += OnProductOutOfStock;
            }
        }

        private void LoadProducts(List<Product> products)
        {
            listBox1.Items.Clear();
            foreach (var product in products) 
            {
                listBox1.Items.Add(product); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product selectedProduct)
            {
                bool isAdded = selectedProduct.CheckQuantity(1);
                if (isAdded)
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
                    LoadProducts(_products);
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

                selectedProduct.Restock(selectedProduct.Quantity);

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

        public void OnProductOutOfStock(object sender, OutOfStockEvent e)
        {
            MessageBox.Show($"Товар {e.ProductName} відсутній на складі. Доступно {e.AvailableStock} одиниць.");

            Check.LogGenerator(_cashRegister, $"Каса {_cashRegister.Id} (модель {_cashRegister.Model}): Товар {e.ProductName} відсутній.");

            var result = MessageBox.Show($"Чи хочете ви додати 5 одиниць товару {e.ProductName}?","Товар відсутній",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var product = _products.FirstOrDefault(p => p.Name == e.ProductName);
                if (product != null)
                {
                    product.StorageQuantity += 5; 

                    MessageBox.Show($"До товару {e.ProductName} додано 5 одиниць на склад.", "Поповнення складу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Check.LogGenerator(_cashRegister, $"Каса {_cashRegister.Id} (модель {_cashRegister.Model}):До товару {e.ProductName} додано 5 одиниць на склад.");

                    LoadProducts(_products);
                }
            }
            else
            {
                MessageBox.Show($"Ви відмовились додавати товар {e.ProductName}.", "Без змін", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
