using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekeningen
{
    public class BankAccount
    {
        private readonly decimal minValue;
        public int AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountNumber, decimal balance, decimal minValue)
        {
            if (balance <= minValue)throw new ArgumentOutOfRangeException(nameof(balance));
            if (accountNumber <= 0) throw new ArgumentOutOfRangeException(nameof(accountNumber));
            this.AccountNumber = accountNumber;
            this.minValue = minValue;
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));

            Balance += amount;
        }

        public bool WithDraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));

            decimal result = Balance - amount;

            if (result < minValue) return false;

            Balance = result;
            return true;
        }

        public bool TransferTo(BankAccount other, decimal amount)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));

            if (!this.WithDraw(amount)) return false;
            other.Deposit(amount);

            return true;
        }
    }
}
