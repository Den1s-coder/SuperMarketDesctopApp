using SuperMarketDesctopApp.Model.Classes;

namespace SuperMarketDesctopApp.Forms
{
    public partial class AddCashRegisterForm : Form
    {
        private SuperMarket _superMarket;

        public event Action CashRegisterAdded;

        public AddCashRegisterForm(SuperMarket superMarket)
        {
            InitializeComponent();
            _superMarket = superMarket;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputId = maskedTextBox1.Text;
            string inputModel = maskedTextBox2.Text;
            if (!int.TryParse(inputId, out int id))
            {
                MessageBox.Show("ID повинен бути повним числом!");
                return;
            }

            _superMarket.AddCashRegister(CashRegister.CreateCashRegister(id, inputModel,_superMarket.GetSuperMarketProducts()));

            CashRegisterAdded?.Invoke();
        }
    }
}
