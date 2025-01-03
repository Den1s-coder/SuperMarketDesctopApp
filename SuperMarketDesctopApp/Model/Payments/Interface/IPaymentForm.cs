﻿using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;

namespace SuperMarketDesctopApp.Model.Payments.Interface
{
    public interface IPaymentForm
    {
        event EventHandler<CustomerServedEvent> CustomerServed;

        void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat);

        public void OnCustomerServed(CustomerServedEvent e);
    }
}
