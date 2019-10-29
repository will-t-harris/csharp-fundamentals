using System;
using System.Collections.Generic;

namespace GradeBook
{

    // define event delegate
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject
    {
        // NamedObject constructor
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }

    
    public class Book : NamedObject
    {
        // Book constructor
        public Book(string name) : base("")
        {
            grades = new List<double>();
            Name = name;
        }

        public Book(List<double> grades, string name)
        {
            this.grades = grades;
            Name = name;
        }

        // Add grade method
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                this.grades.Add(grade);
                // if GradeAdded has a value, fire the event
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        // define GradeAdded event
        public event GradeAddedDelegate GradeAdded;

        // Get statistics method
        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            result.Average = 0.0;

            for (var i = 0; i < grades.Count; i++)
            {
                // Compute high/low/average values
                result.Low = Math.Min(grades[i], result.Low);
                result.High = Math.Max(grades[i], result.High);
                result.Average += grades[i];
            }
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        private List<double> grades;

        public string Name
        {
            get; set;
        }

        public const string CATEGORY = "Science Fiction";
    }
}