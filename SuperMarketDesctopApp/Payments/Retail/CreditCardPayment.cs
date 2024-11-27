using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Payments.Retail
{
    internal struct CreditCardPayment : IPaymentForm
    {
        CashRegister CashRegister;

        double Amount;

        double Paid;

        public CreditCardPayment(CashRegister cashRegister)
        {
            CashRegister = cashRegister;
        }

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.05;

            if (CourierDelivery == true) Amount += 250;

            ProcessPayment(Amount,cashRegister,onlineFormat);
        }

        private void ProcessPayment(double amount,CashRegister cashRegister,string onlineFormat)
        {
            Check.CheckGenerator(cashRegister, amount, "картка",onlineFormat);

            MessageBox.Show($"Оплата карткою на сумму {amount} успiшна!");
        }
    }
}
