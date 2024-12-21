using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Forms;

namespace SuperMarketDesctopApp
{
    public partial class MainForm : Form
    {
        private List<Product> _products;
        private CashRegister _cashRegister;
        public MainForm(List<Product> products, CashRegister cashRegister)
        {
            InitializeComponent();
            _products = products;
            _cashRegister = cashRegister;
        }

        private void Check()
        {
            if (checkBox1.Checked == true) { _cashRegister.CardPayment = true; }
            else  _cashRegister.CardPayment = false;
            if (checkBox2.Checked == true) { _cashRegister.OnlineOrder = true; }
            else _cashRegister.OnlineOrder = false;
            if (checkBox3.Checked == true) { _cashRegister.OnlineDeliveryOrder = true; }
            else _cashRegister.OnlineDeliveryOrder = false;
            if (checkBox4.Checked == true) { _cashRegister.CashOnlineOrder = true; }
            else _cashRegister.CashOnlineOrder = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm(_products);
            addProduct.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashForm cash = new CashForm(_cashRegister);
            cash.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
            BasketForm basket = new BasketForm(_products, _cashRegister);
            basket.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransactionsForm transactions = new TransactionsForm(_cashRegister.Log);
            transactions.ShowDialog();
        }

    }
}
