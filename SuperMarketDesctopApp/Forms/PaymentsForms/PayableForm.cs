﻿using SupermarketConsoleApp.Classes;
using SupermarketConsoleApp.Payments.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SuperMarketDesctopApp.Forms.PaymentsForms
{
    public partial class PayableForm : Form
    {
        private double _amount;

        double Paid;

        private CashRegister _cashRegister;

        private string _paymentFormat;

        public PayableForm(double amount,CashRegister cashRegister,string PaymentFormat)
        {
            InitializeComponent();
            _amount = amount;
            _cashRegister = cashRegister;
            _paymentFormat = PaymentFormat;
            amountUpdate();
        }


        private void amountUpdate()
        {
            label2.Text = _amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out double Paid))
            {
                if (_amount > Paid) { MessageBox.Show("Покупцем надано меньше готівки ніж потрібно для сплати"); }
                else
                {
                    Check.CheckGenerator(_cashRegister, _amount, _paymentFormat);

                    double Rest = Paid - _amount;

                    MessageBox.Show($"Оплата готiвкою на сумму {_amount} успiшна ваша решта {Math.Round(Rest, 2)}");
                }
            }
            else
            {
                MessageBox.Show("Помилка: Невірний формат ціни");
            }
        }
        
    }
}