using System;
using System.Collections.Generic;
using System.Text;

namespace ModularityObjectsState
{
    public class FunctionalBankAccount
    {
        public static Func<int, int> NewWithdraw()
        {
            int internalBalance = 100;

            return (amount) =>
            {
                if (internalBalance > amount)
                {
                    internalBalance -= amount;
                    return internalBalance;
                }
                else
                {
                    throw new ArgumentException("Cannot Withdraw. Amount must be less than balance.");
                }
            };
        }

        public static Func<int, int> MakeWithdraw(int balance)
        {
            return (amount) =>
            {
                if (balance > amount)
                {
                    balance -= amount;
                    return balance;
                }
                else
                {
                    throw new ArgumentException("Cannot Withdraw. Amount must be less than balance.");
                }
            };
        }


        public static Dictionary<string, Func<int,int>> MakeAccount(int balance)
        {
            int Withdraw(int amount)
            {
                if (balance > amount)
                {
                    balance -= amount;
                    return balance;
                }
                else
                {
                    throw new ArgumentException("Cannot Withdraw. Amount must be less than balance.");
                }
            }

            int Deposit(int amount)
            {
                balance += amount;
                return balance;
            }

            var funcDict = new Dictionary<string, Func<int,int>> 
            {
                {"Withdraw", (amount) => Withdraw(amount) },
                {"Deposit", (amount) => Deposit(amount) }
            };

            return funcDict;
        }


    }
}
