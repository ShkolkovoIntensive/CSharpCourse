using System;
namespace CSharpCourse.Lesson1.Homework1
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the symbol: ");
            var symbol = Console.Read();
            var nextSymbol = (char)(symbol + 1);
            Console.WriteLine($"\nThe next symbol is {nextSymbol}");
        }
    }
}
