using SuperMarketDesctopApp.Model.Classes;

namespace SuperMarketDesctopApp.Forms
{
    public partial class AddProductForm : Form
    {
        private List<Product> _products;
        public AddProductForm(List<Product>products)
        {
            InitializeComponent();
            _products = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox1.Text;
            if (double.TryParse(maskedTextBox2.Text, out double price))
            {
                Product.CreateProduct(_products, name, price);
                MessageBox.Show("Товар додано успішно!");
            }
            else
            {
                MessageBox.Show("Помилка: Невірний формат ціни");
            }
        }
    }
}
