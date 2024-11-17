using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using SuperMarketDesctopApp.Forms.PaymentsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Payments.Bulk
{
    internal struct BulkCashPayment : IPaymentForm
    {
        double Amount;

        double Rest;

        public BulkCashPayment(CashRegister cashRegister)
        {
        }

        public void Count(List<Product> Basket,bool LoyaltyCard,bool CourierDelivery, CashRegister cashRegister)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.08;

            if (CourierDelivery == true) Amount += 50;

            string PaymentFormat = "готівка";

            PayableForm payableForm = new PayableForm(Amount, cashRegister, PaymentFormat);
            payableForm.ShowDialog();

            Basket.Clear();
        }
    }
}
