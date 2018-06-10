namespace _05.BookLibrary
{
    using System;

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBNNumber = isbnNumber;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBNNumber { get; set; }

        public decimal Price { get; set; }
    }
}

namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using _05.BookLibrary;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var booksCount = int.Parse(Console.ReadLine());
            var books = ReadBooks(booksCount);

            var dateAsStr = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }

        public static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                var booksArgs = Console.ReadLine().Split().ToArray();
                var title = booksArgs[0];
                var author = booksArgs[1];
                var publisher = booksArgs[2];
                var releaseDate = DateTime.ParseExact(booksArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbnNumber = booksArgs[4];
                var price = decimal.Parse(booksArgs[5]);

                var currrentBook = new Book(title, author, publisher, releaseDate, isbnNumber, price);

                books.Add(currrentBook);
            }

            return books;
        }
    }
}