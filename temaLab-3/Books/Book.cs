using System;
using GenreEnum;

namespace Books
{

    public class Book
    {
        private Book()
        {

        }

        public int BookId {get; private set;}

        public String Title {get; private set;}

        public int Year {get; private set;}

        public int Price {get; private set;}

        public GenreEnum Genre {get; private set;}

        public static void CheckParam(String title)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title can't be null");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Title must be max 100 characters"); // var a = description.Substring(0, Math.Min(150, description.Length));
            }
        }

        public static Book Create(int bookId, String title, int year, int price, GenreEnum genre)
        {
            CheckParam(title);

            return new Book()
            {
                BookId = bookId,
                Title = title,
                Year = year,
                Price = price,
                Genre = genre
            };
        }

    }
}
