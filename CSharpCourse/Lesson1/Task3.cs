using System;
namespace CSharpCourse.Lesson1
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the symbol: ");
            char a = (char)Console.Read();
            Console.WriteLine($"The next symbol is '{(char)++a}'");
        }
    }
}
