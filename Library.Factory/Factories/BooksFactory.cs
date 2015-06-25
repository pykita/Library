using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Library.Factory.Contexts;
using Library.Factory.Models;

namespace Library.Factory.Factories
{
    public static class BooksFactory
    {
        public static List<Book> GetList()
        {
            using (var db = new BookContext())
            {
                return db.Books.ToList();
            }

        }

        public static Book AddBook(Book newBook)
        {
            using (var db = new BookContext())
            {
                var book = db.Books.Add(newBook);
                db.SaveChanges();

                return book;
            }
        }

        public static Book UpdateBook(Book newBook)
        {
            using (var db = new BookContext())
            {
                var currentBook = db.Books.FirstOrDefault(book => book.Id == newBook.Id);
                currentBook.Name = newBook.Name;
                currentBook.AuthorName = newBook.AuthorName;
                currentBook.Serial = newBook.Serial;
                db.SaveChanges();

                return currentBook;
            }
        }

        public static void DeleteBook(Book bookToDelete)
        {
            using (var db =new BookContext())
            {
                var currentBook = db.Books.FirstOrDefault(book => book.Id == bookToDelete.Id);
                db.Books.Remove(currentBook);
                db.SaveChanges();
            }
        }
    }
}
