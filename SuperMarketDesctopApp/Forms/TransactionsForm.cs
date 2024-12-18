﻿using SupermarketConsoleApp.Classes;
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
    public partial class TransactionsForm : Form
    {
        private List<Check> _transaction;
        public TransactionsForm(List<Check> transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            listBox1_update(_transaction);
        }

        private void listBox1_update(List<Check> transaction) 
        {
            foreach (var trans in transaction) 
            {
                listBox1.Items.Add(trans); 
            }
        }
    }
}
