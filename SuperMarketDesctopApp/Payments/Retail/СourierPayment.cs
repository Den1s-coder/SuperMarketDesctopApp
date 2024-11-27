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
    internal struct СourierPayment : IPaymentForm
    {
        double Amount;

        public СourierPayment()
        {
        }

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            CourierDelivery = true;

            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (CourierDelivery == true) Amount += 250;

            string PaymentFormat = "Кур'єром";

            PayableForm payableForm = new PayableForm(Amount,cashRegister,PaymentFormat, onlineFormat);
            payableForm.ShowDialog();

            Basket.Clear();
        }
    }
}
