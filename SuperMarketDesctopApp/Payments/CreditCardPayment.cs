using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Payments
{
    internal struct CreditCardPayment : IPaymentForm
    {
        CashRegister CashRegister;

        double Amount;

        double Paid;

        bool LoyaltyCard = false;

        bool CourierDelivery = false;

        public CreditCardPayment(CashRegister cashRegister)
        {
            CashRegister = cashRegister;
        }

        public void Count(List<Product> Basket)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.05;

            if (CourierDelivery == true) Amount += 250;

            ProcessPayment(Amount);
        }

        private void ProcessPayment(double amount)
        {
            Check.CheckGenerator(CashRegister, amount, "картка");

            Console.WriteLine($"Оплата карткою на сумму {amount} успiшна!");
        }
    }
}
