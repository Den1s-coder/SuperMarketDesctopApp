using SuperMarketDesctopApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketDesctopApp.Forms
{
    public partial class CashForm : Form
    {
        private CashRegister _cashRegister;
        private double _amount;
        public CashForm(CashRegister cashRegister)
        {
            InitializeComponent();
            _cashRegister = cashRegister;
            _amount = cashRegister.GetAmount();
            Amount_Load();
        }

        private void Amount_Load()
        {
            label2.Text = _amount.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(maskedTextBox1.Text, out value))
            {
                _cashRegister.AddCash(value);
            }
            else
            {
                MessageBox.Show("Помилка: Невірний формат введення спробуйте ще раз:", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(maskedTextBox1.Text, out value))
            {
                _cashRegister.Withdraw(value);
            }
            else
            {
                MessageBox.Show("Помилка: Невірний формат введення спробуйте ще раз:", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
