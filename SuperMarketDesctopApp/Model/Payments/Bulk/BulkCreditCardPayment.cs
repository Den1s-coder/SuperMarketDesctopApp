﻿using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Model.Payments.Bulk
{
    internal struct BulkCreditCardPayment : IPaymentForm
    {
        CashRegister CashRegister;

        double Amount;

        double Paid;


        public BulkCreditCardPayment(CashRegister cashRegister)
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

            if (LoyaltyCard == true) Amount -= Amount * 0.08;

            if (CourierDelivery == true) Amount += 50;

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
