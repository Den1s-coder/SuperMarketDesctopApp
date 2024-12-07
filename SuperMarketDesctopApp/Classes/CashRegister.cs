using SupermarketConsoleApp.Payments.Interface;
using SupermarketConsoleApp.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SuperMarketDesctopApp.Classes;

namespace SupermarketConsoleApp.Classes
{
    public class CashRegister
    {
        int Id;
        double Amount = 1000;
        List<Check> Log;
        string Model;
        List<Product> Products;

        public bool CardPayment = false;
        public bool OnlineOrder = false;
        public bool OnlineDeliveryOrder = false;
        public bool CashOnlineOrder = false;

        private CashRegister(int id, string model, List<Product> products)
        {
            Id = id;
            Model = model;
            Products = products;
            Log = new List<Check>();
        }

        public static CashRegister CreateCashRegister(int id, string model, List<Product> products)
        {
            if (string.IsNullOrEmpty(model))
            {
                Console.WriteLine("Помилка: назва моделі не може бути пустою");
                return null;
            }
            return new CashRegister(id, model, products);
        }

        public void Withdraw(double value)
        {
            if (value < 0) value *= -1;

            if (value > Amount)
            {
                MessageBox.Show("Помилка: на касі не достатньо грошей!", "Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Amount -= value;
            MessageBox.Show($"Готiвка успiшно знята \nЗалишилось готiвки на кассi - {Amount}", "Успішне зняття", MessageBoxButtons.OK);
        }

        public void AddCash(double value)
        {
            if (value < 0) value *= -1;

            Amount += value;
            MessageBox.Show($"Поповнення Успiшне на кассi = {Amount} грн", "Поповнення успішне", MessageBoxButtons.OK);
            return;
        }

        public List<Check> GetLogger() { return Log; }

        public int GetId() {  return Id; }

        public double GetAmount() { return Amount; }
    }
}
