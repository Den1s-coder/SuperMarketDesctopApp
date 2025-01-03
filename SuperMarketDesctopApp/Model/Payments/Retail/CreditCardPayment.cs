﻿using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Model.Payments.Retail
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

        public event EventHandler<CustomerServedEvent> CustomerServed;

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.05;

            if (CourierDelivery == true) Amount += 250;

            ProcessPayment(Amount, cashRegister, onlineFormat);

            OnCustomerServed(new CustomerServedEvent(Amount));

            Basket.Clear();
        }

        private void ProcessPayment(double amount, CashRegister cashRegister, string onlineFormat)
        {
            Check.CheckGenerator(cashRegister, onlineFormat, $"Оплата карткою на суму {amount}");
        }

        public void OnCustomerServed(CustomerServedEvent e)
        {
            Console.WriteLine($"Оплата карткою на суму {e} успішна!");
        }
    }
}
