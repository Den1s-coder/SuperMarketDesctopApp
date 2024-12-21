using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Model.Payments
{
    public class CustomerServedEvent
    {
        public double TotalAmount { get; }
        public string PaymentFormat { get; }
        public bool IsLoyaltyCardUsed { get; }
        public bool IsCourierDelivery { get; }

        public CustomerServedEvent(double totalAmount, string paymentFormat, bool isLoyaltyCardUsed, bool isCourierDelivery)
        {
            TotalAmount = totalAmount;
            PaymentFormat = paymentFormat;
            IsLoyaltyCardUsed = isLoyaltyCardUsed;
            IsCourierDelivery = isCourierDelivery;
        }
    }
}
