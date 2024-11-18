using SupermarketConsoleApp.Payments.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Classes
{
    public class Check
    {
        CashRegister CashRegister;
        DateTime Time = DateTime.Now;
        string PaymentForm;
        double Amount;

        private Check(CashRegister cashRegister, string paymentForm, double amount)
        {
            CashRegister = cashRegister;
            PaymentForm = paymentForm;
            Amount = amount;
        }

        public static void CheckGenerator( CashRegister cashRegister, double amount, string PaymentForm)
        {
            cashRegister.GetLogger().Add(new Check(cashRegister, PaymentForm, amount));
        }

        public override string ToString(){return ($"{Time} => Касса №{CashRegister.GetId()}, Оплата на сумму = {Amount}, Форма оплати {PaymentForm}"); }
    }
}
