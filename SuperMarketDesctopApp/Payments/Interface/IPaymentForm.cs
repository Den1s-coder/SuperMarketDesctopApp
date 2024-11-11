using SupermarketConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Payments.Interface
{
    internal interface IPaymentForm
    {
        void Count(List<Product> Basket);
    }
}
