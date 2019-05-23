 using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(90.2);
            book.AddGrade(94.5);
            book.AddGrade(75.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(86.7, result.Average, 1);
            Assert.Equal(94.5, result.High, 1);
            Assert.Equal(75.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
