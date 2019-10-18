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

            var grades = new List<double>() { 4.222, 42.22, 76.2, 2 };
            grades.Add(42);

            var sum = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                sum += grade;
            }

            var average = sum / grades.Count;

            Console.WriteLine($"The average grade is {average:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
        }
    }
}
