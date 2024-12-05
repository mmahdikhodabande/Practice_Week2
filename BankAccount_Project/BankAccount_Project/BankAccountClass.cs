using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    public class BankAccountClass
    {
        private static int Balance = 15;
        static void get_Balance(int balance)
        {
            Balance = balance;
        }
        public static void Deposit(double amount)
        {
            double balance_Double = 0.0;
            balance_Double = Convert.ToDouble(Balance);
            balance_Double = balance_Double + amount;
            get_Balance(Convert.ToInt32(balance_Double));
            Console.Write($"Your account balance is {balance_Double}");
        }
        public static void Withdraw(double amount)
        {
            double balance_Double = 0.0;
            if (Balance == 0)
            {
                Console.Write("Insufficient inventory !!!");
            }
            else
            {
                balance_Double = Convert.ToDouble(Balance);
                balance_Double = balance_Double - amount;
                get_Balance(Convert.ToInt32(balance_Double));
                Console.Write($"Your account balance is {balance_Double}");
            }

        }
    }
}
