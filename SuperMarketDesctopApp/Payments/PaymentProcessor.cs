using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Payments
{
    internal class PaymentProcessor
    {
        IPaymentForm PaymentForm;

        public PaymentProcessor(IPaymentForm paymentForm)
        {
            PaymentForm = paymentForm;
        }

        public void ProcessPayment(List<Product> Basket) 
        {
            PaymentForm.Count(Basket);
        }
    }
}
