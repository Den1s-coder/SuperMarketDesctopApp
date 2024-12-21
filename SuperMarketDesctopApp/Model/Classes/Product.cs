namespace SuperMarketDesctopApp.Model.Classes
{
    public class Product
    {
        public string Name { get; }
        public int ProductId { get; }
        double Price;
        public int Quantity { get; private set; } = 1;

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

        public override string ToString() { return $"Id:{ProductId} Назва: {Name} Цiна: {GetPrice()} Кількість:{Quantity}"; }

        public double GetPrice() { return Price * Quantity; }

        public void AddQuantity() { Quantity++; }
    }
}
