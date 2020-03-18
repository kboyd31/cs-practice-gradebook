using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Kris";
            var upper = MakeUpperCase(name);

            Assert.Equal("Kris", name);
            Assert.Equal("KRIS", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

    [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // Arrange Section - prepare data
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // Act Section - where you perform some results

            // Assert section - test the results to expected
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // Arrange Section - prepare data
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // Act Section - where you perform some results

            // Assert section - test the results to expected
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // Arrange Section - prepare data
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // Act Section - where you perform some results

            // Assert section - test the results to expected
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // Arrange Section - prepare data
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // Act Section - where you perform some results

            // Assert section - test the results to expected
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // Arrange Section - prepare data
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Act Section - where you perform some results

            // Assert section - test the results to expected
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            // Assert.Same works just the same
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name, new List<double>());
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name, new List<double>(){ });
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name, new List<double>(){ });
        }
    }
}