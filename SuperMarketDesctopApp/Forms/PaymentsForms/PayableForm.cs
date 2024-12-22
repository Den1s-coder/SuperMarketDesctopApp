using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;
using SuperMarketDesctopApp.Model.Payments.Bulk;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Forms.PaymentsForms
{
    public partial class PayableForm : Form
    {
        private double _amount;

        double Paid;

        private CashRegister _cashRegister;

        private string _onlineFormat;

        private IPaymentForm _payment;

        public PayableForm(double amount,CashRegister cashRegister,string onlineFormat,IPaymentForm payment)
        {
            InitializeComponent();
            _amount = amount;
            _cashRegister = cashRegister;
            _onlineFormat = onlineFormat;
            _payment = payment;

            _payment.CustomerServed += PaymentCustomerServed;
            amountUpdate();
        }


        private void amountUpdate()
        {
            label2.Text = _amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out double Paid))
            {
                if (_amount > Paid) { MessageBox.Show("Покупцем надано меньше готівки ніж потрібно для сплати"); }
                else
                {
                    Check.CheckGenerator(_cashRegister, _onlineFormat, $"Оплата готiвкою на сумму {_amount}");

                    double Rest = Paid - _amount;

                    _payment.OnCustomerServed(new CustomerServedEvent(_amount, false, false));
                }
            }
            else
            {
                MessageBox.Show("Помилка: Невірний формат ціни");
            }
        }

        private void PaymentCustomerServed(object sender, CustomerServedEvent e)
        {
            MessageBox.Show($"Покупець обслуговуваний: Загальна сума {e.TotalAmount}, ");
        }

    }
}
