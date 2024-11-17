using SupermarketConsoleApp.Classes;
using SuperMarketDesctopApp.Payments.Bulk;
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
    public partial class RetailPaymentForm : Form
    {
        private List<Product> _basket;
        private bool LoyaltyCard = false;
        private bool Delivary = false;
        private CashRegister _cashRegister;
        public RetailPaymentForm(List<Product> basket,CashRegister cashRegister)
        {
            InitializeComponent();
            _basket = basket;
            _cashRegister = cashRegister;
        }

        private void Check()
        {
            if (radioButton1.Checked == true) { LoyaltyCard = true; }
            if (radioButton2.Checked == true) { Delivary = true; }
        }

        private void UpdateButtonStates()
        {
            button2.Enabled = !(_cashRegister.CardPayment);
        }

        private void button1_Click(object sender, EventArgs e) //готівка магазин
        {
            Check();
            BulkCashPayment bulkCashPayment = new BulkCashPayment();
            bulkCashPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister);
        }

        private void button2_Click(object sender, EventArgs e) // картка магазин
        {
            Check();
            BulkCreditCardPayment bulkCreditCardPayment = new BulkCreditCardPayment();
            bulkCreditCardPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister);
        }

        private void button3_Click(object sender, EventArgs e) // готівка кур'єр
        {
            Check();
            BulkСourierPayment bulkCourierPayment = new BulkСourierPayment();
            bulkCourierPayment.Count(_basket, LoyaltyCard, Delivary, _cashRegister);
        }
    }
}
