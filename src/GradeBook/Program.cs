using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 3.14, 420, 911 };
            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
