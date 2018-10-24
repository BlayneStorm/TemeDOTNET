using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using Books;
using FluentAssertions;

namespace BookRepositories.Test
{
    [TestClass]
    public class BookRepositoryUnitTest
    {
        private IEnumerable<Book> SUT;
        private BookRepository BookRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            SUT = new List<Book>() {
                Book.Create(1, "Sherlock Holmes", 1950, 100, GenreEnum.NonFiction),
                Book.Create(2, "Alba ca zapada", 1900, 50, GenreEnum.Fiction),
                Book.Create(3, "Praslea", 1920, 30, GenreEnum.Fiction),
                Book.Create(4, "Marul auriu", 1970, 200, GenreEnum.Fiction),
                Book.Create(5, "Viata lui Stalin", 2015, 500, GenreEnum.NonFiction),
                Book.Create(6, "Mein Kampf", 1935, 400, GenreEnum.NonFiction),
                Book.Create(7, "Winston Churchill", 1967, 200, GenreEnum.NonFiction),
                Book.Create(8, "Prichindeii", 2010, 20, GenreEnum.Fiction),
                Book.Create(9, "Aoleu", 1987, 10, GenreEnum.Fiction),
                Book.Create(10, "Dancila", 2018, 2, GenreEnum.Fiction)
            };
            BookRepository = BookRepository.Create(SUT.ToList());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            SUT = null;
            BookRepository = null;
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksIsCalled_Then_AllBooks()
        {
            // Arrange && Act && Assert
            BookRepository.RetrieveAllBooks().ToList().Count().Should().Be(10);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByYearDescendingIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByYearDescending().ToList();
            
            // Assert
            bookList.ElementAt(0).Year.Should().Be(2018);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByYearAscendingIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByYearAscending().ToList();
           
            // Assert
            bookList.ElementAt(0).Year.Should().Be(1900);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByPriceAscendingIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByPriceAscending().ToList();
            
            // Assert
            bookList.ElementAt(0).Price.Should().Be(2);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByPriceDescendingIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByPriceDescending().ToList();
            
            // Assert
            bookList.ElementAt(0).Year.Should().Be(500);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksGroupedByGenreIsCalled_Then_GenresShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllBooksGroupedByGenre(GenreEnum.Fiction).ToList();
            bool isOrdered = true;

            foreach(Book book in bookList)
            {
                if (book.Genre != GenreEnum.Fiction)
                {
                    isOrdered = false;
                    break;
                }
            }

            // Assert
            isOrdered.Should().Be(true);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksGroupedByGenreWithNoFictionIsCalled_Then_GenresShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllBooksGroupedByGenre(GenreEnum.NonFiction).ToList();
            bool isOrdered = true;

            foreach(Book book in bookList)
            {
                if (book.Genre != GenreEnum.NonFiction)
                {
                    isOrdered = false;
                    break;
                }
            }

            // Assert
            isOrdered.Should().Be(true);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksMethodSyntaxIsCalled_Then_CountShouldBeRight()
        {
            // Arrange && Act && Assert
            BookRepository.RetrieveAllBooksMethodSyntax().ToList().Count().Should().Be(10);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByYearAscendingMethodSyntaxIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByYearAscendingMethodSyntax().ToList();

            // Assert
            bookList.ElementAt(0).Year.Should().Be(1900);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByYearDescendingMethodSyntaxIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByYearDescendingMethodSyntax().ToList();
           
            // Assert
            bookList.ElementAt(0).Year.Should().Be(2018);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByPriceAscendingMethodSyntaxIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByPriceAscendingMethodSyntax().ToList();
            
            // Assert
            bookList.ElementAt(0).Price.Should().Be(2);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllOrderedByPriceDescendingMethodSyntaxIsCalled_Then_OrderShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllOrderByPriceDescendingMethodSyntax().ToList();
            
            // Assert
            bookList.ElementAt(0).Price.Should().Be(500);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksGroupedByGenreMethodSyntaxIsCalled_Then_GenresShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllBooksGroupedByGenreMethodSyntax(GenreEnum.Fiction).ToList();
            bool isOrdered = true;

            foreach(Book book in bookList)
            {
                if (book.Genre != GenreEnum.Fiction)
                {
                    isOrdered = false;
                    break;
                }
            }

            // Assert
            isOrdered.Should().Be(true);
        }

        [TestMethod]
        public void Given_AllBooks_When_RetrieveAllBooksGroupedByGenreMethodSyntaxWithNoFictionIsCalled_Then_GenresShouldBeRight()
        {
            // Arrange && Act
            List<Book> bookList = BookRepository.RetrieveAllBooksGroupedByGenreMethodSyntax(GenreEnum.NonFiction).ToList();
            bool isOrdered = true;

            foreach(Book book in bookList)
            {
                if (book.Genre != GenreEnum.NonFiction)
                {
                    isOrdered = false;
                    break;
                }
            }

            // Assert
            isOrdered.Should().Be(true);
        }
    }
}
