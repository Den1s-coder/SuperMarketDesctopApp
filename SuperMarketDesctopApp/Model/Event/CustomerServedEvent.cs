using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Model.Event
{
    public class CustomerServedEvent
    {
        public double TotalAmount { get; }
        public bool IsLoyaltyCardUsed { get; }
        public bool IsCourierDelivery { get; }

        public CustomerServedEvent(double totalAmount, bool isLoyaltyCardUsed, bool isCourierDelivery)
        {
            TotalAmount = totalAmount;
            IsLoyaltyCardUsed = isLoyaltyCardUsed;
            IsCourierDelivery = isCourierDelivery;
        }
    }
}
