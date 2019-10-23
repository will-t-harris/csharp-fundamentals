using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My Grade Book");
            
            // use console.readline to get user input "please enter a grade"
            do
            {
                Console.WriteLine("Please enter a grade (press the q key to exit)");      
                var input = Console.ReadLine();
                var isDouble = Double.TryParse(input, out double result);
                if (isDouble)
                {
                    var grade = Double.Parse(input);
                    book.AddGrade(grade);
                }
            } while (input.ToLower() != 'q');
            // if the user enters a number, add the number to the gradebook
            // if the user enters 'q', quit the loop
            
            book.AddGrade(90.2);


            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
