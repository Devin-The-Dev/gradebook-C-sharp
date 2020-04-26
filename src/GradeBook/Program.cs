using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            Console.WriteLine($"Sum of Grades: {result}");
            result /= grades.Count;
            Console.WriteLine($"Average Grade: {result:N1}"); //Use N# to specify and round how many digits after the decimal
        }
    }
}
