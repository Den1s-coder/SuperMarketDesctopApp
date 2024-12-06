using SupermarketConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Classes
{
    internal class SuperMarket
    {
        string Name;
        Dictionary<int, CashRegister> CashRegisters = new Dictionary<int, CashRegister>();
        double amount;
        List<Check> Storage = new List<Check>();
        List<Product> SuperMarketProducts = new List<Product>();
        string Adress;
        string EDRPOU;


        private SuperMarket(string name, string adress, string edrpou)
        {
            Name = name;
            Adress = adress;
            EDRPOU = edrpou;
        }

        public static SuperMarket CreateSuperMarket(string name, string adress, string edrpou)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Помилка: Назва супермаркету не може бути пустою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (string.IsNullOrEmpty(adress))
            {
                MessageBox.Show("Помилка: Адресса супермаркету не може бути пустою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (string.IsNullOrEmpty(edrpou))
            {
                MessageBox.Show("Помилка: Код ЕДРПОУ супермаркету не може бути пустим", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new SuperMarket(name, adress, edrpou);
        }

        public void AddCashRegister(CashRegister cashRegister)
        {
            CashRegisters.Add(cashRegister.GetId(), cashRegister);
        }

        public void AddProduct(Product product) //TODO
        {

        }

        public void AddTransactions(Check check) //TODO
        {

        }

    }
}
