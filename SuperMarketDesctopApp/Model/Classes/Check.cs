namespace SuperMarketDesctopApp.Model.Classes
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

        public static void CheckGenerator(CashRegister cashRegister, double amount, string paymentForm, string onlineFormat)
        {
            var check = new Check(cashRegister, paymentForm, amount, onlineFormat);
            cashRegister.Log.Add(check);
            check.SaveTransaction();
        }

        private void SaveTransaction()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string directoryPath = Path.Combine(desktopPath, "Transactions");
                Directory.CreateDirectory(directoryPath);

                string fileName = Path.Combine(directoryPath, $"Register_{CashRegister.Id}_transactions.txt");
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні транзакції: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString() { return $"{OnlineFormat}::{Time} => Касса №{CashRegister.Id}, Оплата на сумму = {Amount}, Форма оплати {PaymentForm}"; }
    }
}
