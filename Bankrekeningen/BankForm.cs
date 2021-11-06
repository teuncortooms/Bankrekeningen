using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankrekeningen
{
    public partial class BankForm : Form
    {
        private readonly BankAccount account1;
        private readonly BankAccount account2;

        public BankForm(Bank bank)
        {
            this.account1 = bank.BankAccounts.Find(acc => acc.AccountNumber == 11111);
            this.account2 = bank.BankAccounts.Find(acc => acc.AccountNumber == 22222);

            InitializeComponent();
        }

        // EVENT HANDLERS

        private void BankForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void BtStorten1_Click(object sender, EventArgs e)
        {
            HandleDepositRequest(account1, tbBedrag1.Text);
        }

        private void BtStorten2_Click(object sender, EventArgs e)
        {
            HandleDepositRequest(account2, tbBedrag2.Text);
        }

        private void BtOpnemen1_Click(object sender, EventArgs e)
        {
            HandleWithdrawalRequest(account1, tbBedrag1.Text);
        }

        private void BtOpnemen2_Click(object sender, EventArgs e)
        {
            HandleWithdrawalRequest(account2, tbBedrag2.Text);
        }

        private void BtOvermaken1_Click(object sender, EventArgs e)
        {
            HandleTransferRequest(account1, account2, tbBedrag1.Text);
        }

        private void BtOvermaken2_Click(object sender, EventArgs e)
        {
            HandleTransferRequest(account2, account1, tbBedrag2.Text);
        }

        // BEHAVIOUR

        private void UpdateView()
        {
            lbSaldo1.Text = CreateSaldoLabel(account1.Balance);
            lbSaldo2.Text = CreateSaldoLabel(account2.Balance);
        }

        private static string CreateSaldoLabel(decimal balance)
        {
            return "Saldo: " + balance.ToString("C");
        }

        private void HandleDepositRequest(BankAccount account, string amountText)
        {
            try
            {
                if (!decimal.TryParse(amountText, out decimal amount)) throw new Exception();

                account.Deposit(amount);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                MessageBox.Show("Geen geldig bedrag.");
            }
            finally
            {
                this.UpdateView();
            }
        }
        private void HandleWithdrawalRequest(BankAccount account, string amountText)
        {
            try
            {
                if (!decimal.TryParse(amountText, out decimal amount)) throw new Exception();

                account.WithDraw(amount);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                MessageBox.Show("Geen geldig bedrag.");
            }
            finally
            {
                this.UpdateView();
            }
        }

        private void HandleTransferRequest(BankAccount sender, BankAccount receiver, string amountText)
        {
            try
            {
                if (!decimal.TryParse(amountText, out decimal amount)) throw new Exception();

                bool success = sender.TransferTo(receiver, amount);

                if (!success) MessageBox.Show("Kon het gespecificeerde bedrag niet overmaken.");
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                MessageBox.Show("Geen geldig bedrag.");
            }
            finally
            {
                this.UpdateView();
            }
        }
    }
}
