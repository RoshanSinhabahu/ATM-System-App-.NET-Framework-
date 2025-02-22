using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp_v1
{
    public partial class Form1: Form
    {
        List<BankAccount> accounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (txtOwner.Text == "")
            {
                MessageBox.Show("Please enter the owner name","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            string owner = txtOwner.Text;
            BankAccount account = new BankAccount(owner);

            accounts.Add(account);

            RefreshGrid();
            txtOwner.Text = string.Empty;
        }
        private void RefreshGrid()
        {
            AccDetailsGrid.DataSource = null;
            AccDetailsGrid.DataSource = accounts;
        }

        private void btnWithdraw_Click(object sender, EventArgs e) //Deposite button
        {
            if(AccDetailsGrid.SelectedRows.Count == 1 && numAmount.Value>0)
            {
                BankAccount selectedBankAccount = AccDetailsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(numAmount.Value);
                RefreshGrid();
                numAmount.Value = 0;
                MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            if (AccDetailsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = AccDetailsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(numAmount.Value);
                RefreshGrid();
                numAmount.Value = 0;
                MessageBox.Show(message,"Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
