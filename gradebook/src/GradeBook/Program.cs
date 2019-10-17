using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {4.222, 42.22, 422.2, 2};
            List<double> grades;

            var result = 0.0;

            foreach(double number in numbers) 
            {
                result += number;
            }

            System.Console.WriteLine(result);

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
