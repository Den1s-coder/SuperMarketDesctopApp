using SuperMarketDesctopApp.Model.Classes;

namespace SuperMarketDesctopApp.Forms
{
    public partial class TransactionsForm : Form
    {
        private List<string> _transaction;
        public TransactionsForm(List<string> transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            listBox1_update(_transaction);
        }

        private void listBox1_update(List<string> transaction) 
        {
            foreach (var trans in transaction) 
            {
                listBox1.Items.Add(trans); 
            }
        }
    }
}
