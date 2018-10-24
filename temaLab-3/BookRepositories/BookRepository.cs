using System;
using System.Collections.Generic;
using Books;
using System.Linq;


namespace BookRepositories
{
    public class BookRepository
    {
        private BookRepository()
        {

        }
        
        public List<Book> BookList {get; private set;}

        public IEnumerable<Book> RetrieveAllBooks()
        {
            // IEnumerable<Book> bookList = 
            //     from book in BookList
            //     select book;

            // return bookList;

            return BookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearDescending()
        {
            IEnumerable<Book> bookList = 
                from book in BookList
                orderby book.Year descending
                select book;

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearAscending()
        {
            IEnumerable<Book> bookList = 
                from book in BookList
                orderby book.Year
                select book;

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByPriceDescending()
        {
            IEnumerable<Book> bookList = 
                from book in BookList
                orderby book.Price descending
                select book;

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByPriceAscending()
        {
            IEnumerable<Book> bookList = 
                from book in BookList
                orderby book.Price
                select book;

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllBooksGroupedByGenre(GenreEnum genre)
        {
            IEnumerable<Book> bookList = 
                from book in BookList
                
                select book;

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllBooksMethodSyntax()
        {
            return BookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearAscendingMethodSyntax()
        {
            IEnumerable<Book> bookList = BookList.OrderBy(book => book.Year);

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByYearDescendingMethodSyntax()
        {
            IEnumerable<Book> bookList = BookList.OrderByDescending(book => book.Year);

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByPriceAscendingMethodSyntax()
        {
            IEnumerable<Book> bookList = BookList.OrderBy(book => book.Price);

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllOrderByPriceDescendingMethodSyntax()
        {
            IEnumerable<Book> bookList = BookList.OrderByDescending(book => book.Price);

            return bookList;
        }

        public IEnumerable<Book> RetrieveAllBooksGroupedByGenreMethodSyntax(GenreEnum genre)
        {
            IEnumerable<Book> bookList = BookList.Where(book => book.Genre == genre);

            return bookList;
        }

        public static BookRepository Create(List<Book> bookList)
        {
            return new BookRepository()
            {
                BookList = bookList
            };
        }
    }
}
