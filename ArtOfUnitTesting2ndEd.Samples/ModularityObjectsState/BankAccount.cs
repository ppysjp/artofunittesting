using System;

namespace ModularityObjectsState
{
    public class BankAccount
    {
        private int _balance;

        public BankAccount(int initialBalance)
        {
            _balance = initialBalance;
        }

        public int Balance 
        {
            get { return _balance; } 
            set { _balance = value; } 
        }

        public int Withdraw(int amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
                return _balance;
            }
            else
            {
                throw new ArgumentException("Cannot Withdraw. Amount must be less than balance.");
            }
        }

        public int Deposit(int amount)
        {
            _balance += amount;
            return _balance;
        }
    }
}
