using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // Book constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        // Add grade method
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                this.grades.Add(grade);
            }
            else 
            {
                System.Console.WriteLine("Invalid value");
            }
        }

        // Get statistics method
        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            while(index < grades.Count)
            {
                // Compute high/low/average values
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index++;
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}