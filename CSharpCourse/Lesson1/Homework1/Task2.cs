using System;
namespace CSharpCourse.Lesson1.Homework1
{
    class Task2
    {
        static void Main()
        {
            var dividend = TryGetNumber("divisible value");
            var divider  = TryGetNumber("divisor");

            Console.WriteLine(divider == 0 ? "You can't divide by zero!" : $"Result: {dividend / divider}");

            int TryGetNumber(string message)
            {
                Console.Write($"Enter the {message}: ");
                var value = Console.ReadLine();

                if (int.TryParse(value, out var number) == false)
                    throw new FormatException("You entered incorrect data!");

                return number;
            }
        }
    }
}
