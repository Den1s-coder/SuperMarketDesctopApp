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
        string OnlineFormat;
        private Check(CashRegister cashRegister, string paymentForm, double amount, string onlineFormat)
        {
            CashRegister = cashRegister;
            PaymentForm = paymentForm;
            Amount = amount;
            OnlineFormat = onlineFormat;
        }

        public static void CheckGenerator( CashRegister cashRegister, double amount, string PaymentForm,string onlineFormat)
        {
            cashRegister.GetLogger().Add(new Check(cashRegister, PaymentForm, amount,onlineFormat));
        }

        public override string ToString(){return ($"{OnlineFormat}::{Time} => Касса №{CashRegister.GetId()}, Оплата на сумму = {Amount}, Форма оплати {PaymentForm}"); }
    }
}
