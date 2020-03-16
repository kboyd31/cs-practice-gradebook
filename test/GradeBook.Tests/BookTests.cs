using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange Section - prepare data
            var book = new Book("Kris's Grade Book", new List<double>() {89.1, 90.5, 77.3});

            // Act Section - where you perform some results
            var average = book.GetAverageGrade();

            // Assert section - test the results to expected
            Assert.Equal(8.4, average);
        }
    }
}