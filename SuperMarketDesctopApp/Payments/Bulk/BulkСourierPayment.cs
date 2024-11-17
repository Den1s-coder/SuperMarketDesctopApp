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
    internal struct BulkСourierPayment : IPaymentForm
    {
        double Amount;

        public BulkСourierPayment(CashRegister cashRegister)
        {
        }

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister)
        {
            CourierDelivery = true;

            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (CourierDelivery == true) Amount += 0;

            string PaymentFormat = "Кур'єром";

            PayableForm payableForm = new PayableForm(Amount, cashRegister, PaymentFormat);
            payableForm.ShowDialog();

            Basket.Clear();
        }
    }
}
