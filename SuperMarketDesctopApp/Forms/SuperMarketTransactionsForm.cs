using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SuperMarketDesctopApp.Forms
{
    public partial class SuperMarketTransactionsForm : Form
    {
        private List<string> _transactions;
        public SuperMarketTransactionsForm(List<string> transactions)
        {
            InitializeComponent();
            _transactions = transactions;
            listBox1_update(_transactions);
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
