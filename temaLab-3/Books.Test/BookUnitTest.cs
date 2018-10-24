using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

namespace Books.Test
{
    [TestClass]
    public class BookUnitTest
    {
        [TestMethod]
        public void Given_TitleIsNull_When_CheckParamIsCalled_Should_ThrowException()
        {
            // Arrange && Act
            Action act = () => Book.CheckParam(null);

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_TitleExceedsMaxLength_When_CheckParamIsCalled_Should_ThrowException()
        {
            // Arrange && Act
            Action act = () => Book.CheckParam("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void Given_AllIsGood_When_CreateIsCalled_Should_ReturnNewBook()
        {
            // Arrange && Act
            Book book = Book.Create(1, "Stalin", 1950, 100, GenreEnum.Fiction);

            // Assert
            book.Year.Should().Be(1950);
        }
    }
}
