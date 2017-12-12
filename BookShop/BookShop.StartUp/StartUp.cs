namespace BookShop
{
    using System.Globalization;
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models;
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var db = new BookShopContext();

            //var input = int.Parse(Console.ReadLine());
            //var input = Console.ReadLine();
            var result = RemoveBooks(db);

            Console.WriteLine(result);
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(b => b.Copies < 4200).ToList();
            var count = books.Count();

            context.RemoveRange(books);

            context.SaveChanges();

            return count;


        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    c.Name,
                    Books = c.CategoryBooks.Select(cb => cb.Book)
                    .OrderByDescending(b => b.ReleaseDate).Take(3)
                }).ToList();

            var sb = new StringBuilder();

            foreach (var c in categories)
            {
                sb.AppendLine($"--{c.Name}");
                foreach (var b in c.Books)
                {
                    sb.AppendLine($"{b.Title} ({b.ReleaseDate.Value.Year})");
                }
            }

            return sb.ToString();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Price = c.CategoryBooks.Select(b => b.Book.Copies * b.Book.Price).Sum()
                }).OrderByDescending(c => c.Price).ToList();

            var sb = new StringBuilder();

            foreach (var item in categories)
            {
                sb.AppendLine($"{item.Name} ${item.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var books = context.Books
                .Include(b => b.Author)
                .Select(b => new
                {
                    b.Author.FirstName,
                    b.Author.LastName,
                    b.Copies
                })
                .ToList();

            var dict = new Dictionary<string, int>();

            foreach (var book in books)
            {
                if (!dict.ContainsKey(book.FirstName + ' ' + book.LastName))
                {
                    dict.Add(book.FirstName + ' ' + book.LastName, book.Copies);
                }
                else
                {
                    dict[book.FirstName + ' ' + book.LastName] += book.Copies;
                }
            }

            var sb = new StringBuilder();

            foreach (var item in dict.OrderByDescending(d => d.Value))
            {
                sb.AppendLine($"{item.Key} - {item.Value}");
            }
            return sb.ToString().Trim();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books.Where(b => b.Title.Length > lengthCheck).Select(b => b.Title).ToList();

            var result = books.Count;

            return result;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var pattern = $"^{input.ToLower()}.*$";

            var books = context.Books.Where(b => Regex.Match(b.Author.LastName.ToLower(), pattern).Success)
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})").ToList();

            var result = string.Join(Environment.NewLine, books);
            return result;
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var pattern = $"{input.ToLower()}";

            var books = context.Books.Where(b => Regex.Match(b.Title.ToLower(), pattern).Success).Select(b => b.Title).OrderBy(t => t).ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        //Judge 75/100
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var pattern = $"{input.ToLower()}$";

            var authors = context.Authors.Where(a => Regex.Match(a.FirstName.ToLower(), pattern).Success).OrderBy(a => a.FirstName).Select(a => $"{a.FirstName} {a.LastName}").ToList();

            var result = string.Join(Environment.NewLine, authors);
            return result;
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate < DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.CurrentCulture))
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                });

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            var titles = context.Books.Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower()))).Select(b => b.Title).OrderBy(t => t).ToList();


            var result = string.Join(Environment.NewLine, titles);

            return result;
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var books = context.Books.Where(b => b.ReleaseDate.Value.Year != year).OrderBy(b => b.BookId).Select(b => b.Title).ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price >= 40)
                .OrderByDescending(b => b.Price)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                }).ToList();


            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            var result = sb.ToString().Trim();
            return result;
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var titles = context.Books.Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000).OrderBy(b => b.BookId).Select(b => b.Title).ToList();

            var result = string.Join(Environment.NewLine, titles);

            return result;
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var enumInt = -1;

            switch (command.ToLower())
            {
                case "minor":
                    enumInt = 0;
                    break;
                case "teen":
                    enumInt = 1;
                    break;
                case "adult":
                    enumInt = 2;
                    break;
            }

            var titles = context.Books.Where(b => b.AgeRestriction == (AgeRestriction)enumInt).OrderBy(b => b.Title).Select(b => b.Title).ToList();

            var result = string.Join(Environment.NewLine, titles);

            return result;
        }
    }
}
