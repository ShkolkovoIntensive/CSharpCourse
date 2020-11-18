using System;
namespace CSharpCourse.Lesson1
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dividend: ");
            string tmp = Console.ReadLine();
            if (!Int32.TryParse(tmp, out int a))
            {
                Console.WriteLine("ERROR: Incorrect input!");
                Environment.Exit(-1);
            }
            Console.Write("Enter the divider: ");
            tmp = Console.ReadLine();
            if (!Int32.TryParse(tmp, out int b))
            {
                Console.WriteLine("ERROR: Incorrect input!");
                Environment.Exit(-1);
            }
            if (b == 0)
            {
                Console.WriteLine("ERROR: Division by zero!");
                Environment.Exit(-1);
            } else
            {
                var output = a / (float)b;
                Console.WriteLine($"The quotient is {output}");
            }
        }
    }
}
