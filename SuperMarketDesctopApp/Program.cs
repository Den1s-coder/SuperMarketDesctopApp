using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Forms;

namespace SuperMarketDesctopApp
{
    internal static class Program
    { 
        [STAThread]
        static void Main()
        {
            List<Product> Products = new List<Product>();

            Product.CreateProduct(Products, "banana", 15);
            Product.CreateProduct(Products, "Bread", 10);
            Product.CreateProduct(Products, "Fanta", 36.50);
            Product.CreateProduct(Products, "Milk", 33.70);
            Product.CreateProduct(Products, "Chocolate Ice Cream", 30);
            Product.CreateProduct(Products, "Coca-Cola", 37);
            Product.CreateProduct(Products, "Pepsi-Cola", 45);
            Product.CreateProduct(Products, "Cheese", 15);
            Product.CreateProduct(Products, "Pineapple", 15.50);
            Product.CreateProduct(Products, "Water", 5.30);

            SuperMarket superMarket = SuperMarket.CreateSuperMarket("Class", "Oleksiivka", "AD1234",Products);

            CashRegister cashRegister = CashRegister.CreateCashRegister(1, "Model_1", Products);

            superMarket.AddCashRegister(cashRegister);

            ApplicationConfiguration.Initialize();

            Application.Run(new SuperMarketForm(superMarket));
        }
    }
}