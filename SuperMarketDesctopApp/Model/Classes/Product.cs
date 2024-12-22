using SuperMarketDesctopApp.Model.Event;

namespace SuperMarketDesctopApp.Model.Classes
{
    public class Product
    {
        public string Name { get; }
        public int ProductId { get; }
        private double Price { get; }
        public int Quantity { get; private set; } = 1;
        public int StorageQuantity { get; set; } = 5;

        public event EventHandler<OutOfStockEvent> ProductOutOfStock;

        private Product(string name, int productId, double price)
        {
            Name = name;
            ProductId = productId;
            Price = price;
        }

        public static void CreateProduct(List<Product> Products, string name, double price)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Помилка: Назва продукту не може бути пустою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Products.Any(p => p.Name == name))
            {
                MessageBox.Show($"Помилка: Товар {name} вже iснує ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Products.Add(new Product(name, Products.Count, price));
        }

        public bool CheckQuantity(int quantity)
        {
            if (quantity > StorageQuantity)
            {
                // Если товара недостаточно, вызываем событие
                OnProductOutOfStock(new OutOfStockEvent(Name, StorageQuantity));
                return false; // Возвращаем false, если товар не может быть добавлен
            }
            else
            {
                // Уменьшаем количество на складе
                StorageQuantity -= quantity;
                return true; // Возвращаем true, если товар можно добавить
            }
        }

        public void Restock(int quantity)
        {
            if (quantity > 0)
            {
                StorageQuantity += quantity;

                Quantity = 1;
            }
        }

        protected virtual void OnProductOutOfStock(OutOfStockEvent e)
        {
            ProductOutOfStock?.Invoke(this, e);
        }

        public override string ToString() { return $"Назва: {Name} Цiна: {GetPrice()} Кількість:{StorageQuantity}"; }
        public double GetPrice() { return Price * Quantity; }
        public void AddQuantity() { Quantity++; }
    }
}
