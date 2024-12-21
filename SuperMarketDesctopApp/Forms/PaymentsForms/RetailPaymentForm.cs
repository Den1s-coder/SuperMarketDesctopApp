using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Payments.Retail;

namespace SuperMarketDesctopApp.Forms
{
    public partial class RetailPaymentForm : Form
    {
        private List<Product> _basket;
        private bool LoyaltyCard = false;
        private bool Delivary = false;
        private CashRegister _cashRegister;
        public RetailPaymentForm(List<Product> basket, CashRegister cashRegister)
        {
            InitializeComponent();
            _basket = basket;
            _cashRegister = cashRegister;
            UpdateButtonStates();
        }

        private void Check()
        {
            if (radioButton1.Checked == true) { LoyaltyCard = true; }
            if (radioButton2.Checked == true) { Delivary = true; }
        }

        private void UpdateButtonStates()
        {
            button2.Enabled = _cashRegister.CardPayment;
            button4.Enabled = _cashRegister.OnlineOrder && _cashRegister.CashOnlineOrder;
            button5.Enabled = _cashRegister.OnlineOrder && _cashRegister.CardPayment;
            button6.Enabled = _cashRegister.OnlineOrder && _cashRegister.OnlineDeliveryOrder;
        }

        private void button1_Click(object sender, EventArgs e) //готівка магазин
        {
            Check();
            CashPayment CashPayment = new CashPayment();
            CashPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button2_Click(object sender, EventArgs e) // картка магазин
        {
            Check();
            CreditCardPayment CreditCardPayment = new CreditCardPayment();
            CreditCardPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button3_Click(object sender, EventArgs e) // готівка кур'єр
        {
            Check();
            СourierPayment CourierPayment = new СourierPayment();
            CourierPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button4_Click(object sender, EventArgs e) //готівка магазин онлайн
        {
            Check();
            CashPayment CashPayment = new CashPayment();
            CashPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }

        private void button5_Click(object sender, EventArgs e)// картка магазин онлайн
        {
            Check();
            CreditCardPayment CreditCardPayment = new CreditCardPayment();
            CreditCardPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }

        private void button6_Click(object sender, EventArgs e)//готівка магазин онлайн
        {
            Check();
            СourierPayment CourierPayment = new СourierPayment();
            CourierPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }
    }
}
