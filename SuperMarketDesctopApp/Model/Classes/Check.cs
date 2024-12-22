namespace SuperMarketDesctopApp.Model.Classes
{
    public class Check
    {
        CashRegister CashRegister;
        DateTime Time = DateTime.Now;
        string OnlineFormat;
        string Message;

        private Check(CashRegister cashRegister, string onlineFormat, string message)
        {
            CashRegister = cashRegister;
            OnlineFormat = onlineFormat;
            Message = message;
        }

        public static void CheckGenerator(CashRegister cashRegister, string onlineFormat,string message)
        {
            var check = new Check(cashRegister, onlineFormat, message);
            cashRegister.AddLog(check.ToString());
            check.SaveTransaction();
        }

        public static void LogGenerator(CashRegister cashRegister,string message)
        {
            cashRegister.AddLog(message);
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

        public override string ToString() { return $"{OnlineFormat}::{Time} => Касса №{CashRegister.Id}, {Message}"; }
    }
}
