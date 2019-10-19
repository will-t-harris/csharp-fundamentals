using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My Grade Book");
            book.AddGrade(90.2);
            book.AddGrade(75.5);
            book.AddGrade(88.8);

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
        }
    }
}
