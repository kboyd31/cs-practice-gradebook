using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name, List<double> grades)
        {
            this.grades = grades;
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics() {
            var result = new Statistics();

            result.Average = this.GetAverageGrade();
            result.Low = this.GetLowestGrade();
            result.High = this.GetHighestGrade();

            return result;
        }

        private double GetAverageGrade() {
            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;

            return result;
        }

        private double GetHighestGrade() {
            var highest = double.MinValue;

            foreach (var grade in grades)
            {
                highest = Math.Max(grade, highest);
            }

            return highest;
        }

        private double GetLowestGrade() {
            var lowest = double.MaxValue;

            foreach (var grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }

            return lowest;
        }
    }
}