using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name, List<double> grades)
        {
            this.grades = grades;
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats() {
            System.Console.WriteLine($"The highest grade is: {this.GetHighestGrade()}");
            System.Console.WriteLine($"The lowest grade is: {this.GetLowestGrade()}");
            System.Console.WriteLine($"The average grade is: {this.GetAverageGrade():N1}");
        }

        public double GetAverageGrade() {
            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;

            return result;
        }

        public double GetHighestGrade() {
            var highest = double.MinValue;

            foreach (var grade in grades)
            {
                highest = Math.Max(grade, highest);
            }

            return highest;
        }

        public double GetLowestGrade() {
            var lowest = double.MaxValue;

            foreach (var grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }

            return lowest;
        }
    }
}