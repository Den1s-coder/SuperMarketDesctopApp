using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp.Classes
{
    internal class Product
    {
        string Name;
        int ProductId;
        double Price;
        int Quantity = 1;

        private Product(string name, int productId, double price)
        {
            Name = name;
            ProductId = productId;
            Price = price;
        }

        public static void CreateProduct(List<Product> Products, string name, double price)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Помилка: Назва продукту не може бути пустою");
                return;
            }

            if (Products.Any(p => p.Name == name))
            {
                Console.WriteLine($"Помилка: Товар {name} вже iснує ");
                return;
            }

            Products.Add(new Product(name, Products.Count, price));
        }

        public static void AddProduct(List<Product> products) 
        {
            Console.WriteLine("Вкажiть назву товару");
            string name = Console.ReadLine();

            Console.WriteLine("Вкажiть цiну товару (Якщо цiна з копiйками вказувати у форматi[0,50])");
            double price;

            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Помилка: Невірний формат введення спробуйте ще раз:");
            };

            CreateProduct(products, name, price);
        }

        public void GetInfo() { Console.WriteLine($"Id:{ProductId} Назва: {Name} Цiна: {Price}"); }

        public double GetPrice() { return Price * Quantity; }

        public int GetId() { return ProductId; }

        public int GetQuantity() { return Quantity; }

        public void AddQuantity() { Quantity++; }
    }
}
