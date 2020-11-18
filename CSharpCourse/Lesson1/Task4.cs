using System;
namespace CSharpCourse.Lesson1
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the coefficient a: ");
            string tmp = Console.ReadLine();
            if(!Int32.TryParse(tmp, out int a))
            {
                Console.WriteLine("ERROR: Incorrect input!");
                Environment.Exit(-1);
            }
            Console.Write("Enter the coefficient b: ");
            tmp = Console.ReadLine();
            if (!Int32.TryParse(tmp, out int b))
            {
                Console.WriteLine("ERROR: Incorrect input!");
                Environment.Exit(-1);
            }
            Console.Write("Enter the coefficient c: ");
            tmp = Console.ReadLine();
            if (!Int32.TryParse(tmp, out int c))
            {
                Console.WriteLine("ERROR: Incorrect input!");
                Environment.Exit(-1);
            }
            int D = b * b - 4 * a * c;
            if (D > 0)
            {
                var x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                var x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine($"There are 2 roots in this equation: {x1} and {x2}");
            } else if (D == 0)
            {
                var x = -b / (2 * a);
                Console.WriteLine($"There is 1 root in this equation: {x}");
            } else
            {
                Console.WriteLine("There are no roots in this equation");
            }
        }
    }
}
