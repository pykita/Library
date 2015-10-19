using System.Collections.Generic;
using System.Linq;
using Library.Factory.Contexts;
using Library.Factory.Models;

namespace Library.Factory.Factories
{
    public static class BooksFactory
    {
        public static List<Book> GetList()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }

        }

        public static Book AddBook(Book newBook)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Add(newBook);
                db.SaveChanges();

                return book;
            }
        }

        public static Book GetBookById(int id)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.FirstOrDefault(b => b.Id == id);
                if (book != null && book.User != null)
                {
                    db.Users.Attach(book.User);
                }
                
                return book;
            }
        }

        public static Book UpdateBook(Book newBook)
        {
            using (var db = new LibraryContext())
            {
                db.Users.Attach(newBook.User);

                var currentBook = db.Books.FirstOrDefault(book => book.Id == newBook.Id);
                currentBook.Name = newBook.Name;
                currentBook.AuthorName = newBook.AuthorName;
                currentBook.Serial = newBook.Serial;
                currentBook.Year = newBook.Year;
                currentBook.User = newBook.User;
                db.SaveChanges();

                return currentBook;
            }
        }

            public static void DeleteBook(Book bookToDelete)
            {
                using (var db = new LibraryContext())
                {
                    var currentBook = db.Books.FirstOrDefault(book => book.Id == bookToDelete.Id);
                    db.Books.Remove(currentBook);
                    db.SaveChanges();
                }
            }
    }
}
