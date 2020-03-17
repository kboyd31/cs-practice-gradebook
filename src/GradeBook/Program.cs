using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kris's Grade Book", new List<double> { 12.7, 14.9, 1.4, 8.3, 4.9 });
            var statistics = book.GetStatistics();

            System.Console.WriteLine($"The highest grade is: {statistics.High}");
            System.Console.WriteLine($"The lowest grade is: {statistics.Low}");
            System.Console.WriteLine($"The average grade is: {statistics.Average:N1}");
        }
    }
}
