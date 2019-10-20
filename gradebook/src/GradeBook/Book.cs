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
            this.grades.Add(grade);
        }

        // Get statistics method
        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                // Comput high/low/average values
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}