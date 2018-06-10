﻿using System.Collections.Generic;

namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            var booksCount = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            books = ReadBooks(booksCount);

            var booksPrice = new Dictionary<string, decimal>();

            var library = new Library("FirstLibrary", books);

            GetBooksPrice(library.Books, booksPrice);

            booksPrice = booksPrice
                 .OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var book in booksPrice)
            {
                Console.WriteLine($"{book.Key} -> {book.Value:f2}");
            }
        }

        private static void GetBooksPrice(List<Book> books, Dictionary<string, decimal> booksPrice)
        {
            foreach (var book in books)
            {
                if (!booksPrice.ContainsKey(book.Author))
                {
                    booksPrice.Add(book.Author, 0.0m);
                }

                booksPrice[book.Author] += book.Price;
            }
        }

        private static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                var booksArgs = Console.ReadLine().Split().ToArray();
                var title = booksArgs[0];
                var author = booksArgs[1];
                var publisher = booksArgs[2];
                var releaseDate = booksArgs[3];
                var isbnNumber = booksArgs[4];
                var price = decimal.Parse(booksArgs[5]);

                var currrentBook = new Book(title, author, publisher, releaseDate, isbnNumber, price);

                books.Add(currrentBook);
            }

            return books;
        }
    }
}

public class Book
{
    public Book(string title, string author, string publisher, string releaseDate, string isbnNumber, decimal price)
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

    public string ReleaseDate { get; set; }

    public string ISBNNumber { get; set; }

    public decimal Price { get; set; }
}

public class Library
{
    public Library(string name, List<Book> books)
    {
        this.Name = name;
        this.Books = books;
    }

    public string Name { get; set; }

    public List<Book> Books { get; set; }
}