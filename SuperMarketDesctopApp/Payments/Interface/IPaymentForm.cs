﻿using SupermarketConsoleApp.Classes;
using SuperMarketDesctopApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Payments.Interface
{
    public interface IPaymentForm
    {
        void Count(List<Product> Basket,bool LoyaltyCard, bool CourierDelivery,CashRegister cashRegister,string onlineFormat);
    }
}
