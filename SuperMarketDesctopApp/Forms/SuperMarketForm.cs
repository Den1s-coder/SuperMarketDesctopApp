using SupermarketConsoleApp.Classes;
using SuperMarketDesctopApp.Classes;
using System.Windows.Forms;

namespace SuperMarketDesctopApp.Forms
{
    public partial class SuperMarketForm : Form
    {
        private SuperMarket _superMarket;

        public SuperMarketForm(SuperMarket superMarket)
        {
            InitializeComponent();
            _superMarket = superMarket;
            LoadCashRegisters(superMarket.GetCashRegisters());
        }

        public void LoadCashRegisters(Dictionary<int, CashRegister> CashRegisters)
        {
            listBox1.Items.Clear();

            foreach (var cashRegister in CashRegisters.Values)
            {
                listBox1.Items.Add(cashRegister);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is CashRegister cashRegister)
            {
                MainForm mainForm = new MainForm(_superMarket.GetSuperMarketProducts(), cashRegister);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Виберіть касу");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCashRegisterForm AddRegister = new AddCashRegisterForm(_superMarket);

            AddRegister.CashRegisterAdded += () =>
            {
                listBox1.Items.Clear();
                LoadCashRegisters(_superMarket.GetCashRegisters());
            };

            AddRegister.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is CashRegister cashRegister)
            {
                _superMarket.RemoveCashRegister(cashRegister);
                LoadCashRegisters(_superMarket.GetCashRegisters());
            }
            else
            {
                MessageBox.Show("Виберіть касу");
            }
        }
    }
}
