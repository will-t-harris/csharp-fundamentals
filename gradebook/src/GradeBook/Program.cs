using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {4.222, 42.22, 422.2, 2};
            var grades = new List<double>() {4.222, 42.22, 422.2, 2};
            grades.Add(42);

            var sum = 0.0;

            foreach(double grade in grades) 
            {
                sum += grade;
            }

            var average = sum / grades.Count;

            System.Console.WriteLine(average);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
