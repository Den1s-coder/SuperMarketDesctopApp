using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using SuperMarketDesctopApp.Forms.PaymentsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Payments.Retail
{
    internal struct CashPayment : IPaymentForm
    {
        double Amount;

        public CashPayment()
        {

        }

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.05;

            if (CourierDelivery == true) Amount += 250;

            string PaymentFormat = "готівка";

            PayableForm payableForm = new PayableForm(Amount, cashRegister, PaymentFormat, onlineFormat);
            payableForm.ShowDialog();

            Basket.Clear();
        }
    }
}
