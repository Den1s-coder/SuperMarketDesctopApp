using SupermarketConsoleApp.Classes;
using SuperMarketDesctopApp.Classes;
using SuperMarketDesctopApp.Payments.Bulk;
using SuperMarketDesctopApp.Payments.Retail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketDesctopApp.Forms
{
    public partial class BulkPaymentForm : Form
    {
        private List<Product> _basket;
        private bool LoyaltyCard = false;
        private bool Delivary = false;
        private CashRegister _cashRegister;
        public BulkPaymentForm(List<Product> basket, CashRegister cashRegister)
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

        private void button1_Click(object sender, EventArgs e) //готівка магазин офлайн
        {
            Check();
            BulkCashPayment bulkCashPayment = new BulkCashPayment();
            bulkCashPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button2_Click(object sender, EventArgs e) // картка магазин офлайн
        {
            Check();
            BulkCreditCardPayment bulkCreditCardPayment = new BulkCreditCardPayment();
            bulkCreditCardPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button3_Click(object sender, EventArgs e) // готівка кур'єр офлайн
        {
            Check();
            BulkСourierPayment bulkCourierPayment = new BulkСourierPayment();
            bulkCourierPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "offline");
        }

        private void button4_Click(object sender, EventArgs e) //готівка магазин онлайн
        {
            Check();
            BulkCashPayment bulkCashPayment = new BulkCashPayment();
            bulkCashPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }

        private void button5_Click(object sender, EventArgs e)// картка магазин онлайн
        {
            Check();
            BulkCreditCardPayment bulkCreditCardPayment = new BulkCreditCardPayment();
            bulkCreditCardPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }

        private void button6_Click(object sender, EventArgs e)//готівка магазин онлайн
        {
            Check();
            BulkСourierPayment bulkCourierPayment = new BulkСourierPayment();
            bulkCourierPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister, "online");
        }
    }
}
