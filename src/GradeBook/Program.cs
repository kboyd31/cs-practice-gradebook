using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var grades = new List<double> { 12.7, 14.9, 1.4, 8.3, 4.9 };
            var book = new Book("Kris's Grade Book", grades);

            book.ShowStats();
        }
    }
}
