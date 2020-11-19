using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Lesson1.Homework2
{
    class Task2
    {
        enum BankAccounts
        {
            Current,
            Credit,
            Deposit,
            Budgetary
        }
        struct Information
        {
            public int number;
            public BankAccounts account;
            public decimal balance;
        }
        static void Main(string[] args)
        {
            Information info;
            info.number = 0;
            info.account = BankAccounts.Budgetary;
            info.balance = 10005.8M;
            Console.WriteLine($"Your bank account number is {info.number}, type is {info.account}, balance is {info.balance}.");
        }
    }
}
