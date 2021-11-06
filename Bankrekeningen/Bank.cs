using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekeningen
{
    public class Bank
    {
        public List<BankAccount> BankAccounts { get; }

        public Bank()
        {
            this.BankAccounts = new List<BankAccount>();
            InitAccounts();
        }

        private void InitAccounts()
        {
            BankAccounts.Add(new BankAccount(11111, 1000, 0));
            BankAccounts.Add(new BankAccount(22222, 500, 0));
        }
    }
}
