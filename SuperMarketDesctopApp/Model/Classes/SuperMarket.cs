namespace SuperMarketDesctopApp.Model.Classes
{
    public class SuperMarket
    {
        private string Name;
        Dictionary<int, CashRegister> CashRegisters = [];
        double amount;
        List<Check> Storage = new List<Check>();
        List<Product> SuperMarketProducts = new List<Product>();
        string Adress;
        string EDRPOU;


        private SuperMarket(string name, string adress, string edrpou, List<Product> products)
        {
            Name = name;
            Adress = adress;
            EDRPOU = edrpou;
            SuperMarketProducts = products; 
        }

        public static SuperMarket? CreateSuperMarket(string name, string adress, string edrpou, List<Product> products)
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

            return new SuperMarket(name, adress, edrpou, products);
        }

        public void AddCashRegister(CashRegister cashRegister)
        {
            if (CashRegisters.ContainsKey(cashRegister.Id)) 
            {
                MessageBox.Show("Касса з таким ід вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CashRegisters.Add(cashRegister.Id, cashRegister);
        }

        public double GetAmount()
        {
            double superMarketAmount = 0;

            foreach (var item in CashRegisters) { superMarketAmount += item.Value.Amount; }
            
            return superMarketAmount;
        }

        public Dictionary<int,CashRegister> GetCashRegisters() { return CashRegisters; }

        public List<Product> GetSuperMarketProducts() { return SuperMarketProducts; }

        public void RemoveCashRegister(CashRegister cashRegister) { CashRegisters.Remove(cashRegister.Id); }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine($"{Name},{Adress},{EDRPOU}");

                    writer.WriteLine(SuperMarketProducts.Count);
                    foreach (var product in SuperMarketProducts)
                    {
                        writer.WriteLine($"{product.Name},{product.GetPrice()},{product.ProductId}");
                    }

                    writer.WriteLine(CashRegisters.Count);
                    foreach (var register in CashRegisters.Values)
                    {
                        writer.WriteLine($"{register.Id},{register.Model},{register.Amount}");
                    }
                }
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static SuperMarket LoadFromFile(string filename)
        {
            try
            {
                using StreamReader reader = new StreamReader(filename);
                string[] marketInfo = reader.ReadLine().Split(',');
                string name = marketInfo[0];
                string address = marketInfo[1];
                string edrpou = marketInfo[2];

                List<Product> products = new List<Product>();
                int productCount = int.Parse(reader.ReadLine());
                for (int i = 0; i < productCount; i++)
                {
                    string[] productInfo = reader.ReadLine().Split(',');
                    Product.CreateProduct(products, productInfo[0], double.Parse(productInfo[1]));
                }

                SuperMarket market = new SuperMarket(name, address, edrpou, products);

                int registerCount = int.Parse(reader.ReadLine());
                for (int i = 0; i < registerCount; i++)
                {
                    string[] registerInfo = reader.ReadLine().Split(',');
                    var cashRegister = CashRegister.CreateCashRegister(
                        int.Parse(registerInfo[0]),
                        registerInfo[1],
                        products);

                    if (cashRegister != null)
                    {
                        cashRegister.Amount = double.Parse(registerInfo[2]);
                        market.AddCashRegister(cashRegister);
                    }
                }

                MessageBox.Show("Дані успішно завантажено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return market;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void SaveSuperMarket()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані супермаркету";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFileDialog.FileName);
            }
        }

        public static SuperMarket LoadSuperMarket()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            openFileDialog.Title = "Завантажити дані супермаркету";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return LoadFromFile(openFileDialog.FileName);
            }
            return null;
        }
    }
}
