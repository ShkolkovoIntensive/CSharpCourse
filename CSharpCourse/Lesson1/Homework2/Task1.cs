using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Lesson1.Homework2
{
    class Task1
    {
        enum BankAccounts
        {
            Current,
            Credit,
            Deposit,
            Budgetary
        }
        static void Main(string[] args)
        {
            BankAccounts Account = BankAccounts.Credit;
            Console.WriteLine($"Your bank account type is {Account}");
        }
    }
}
