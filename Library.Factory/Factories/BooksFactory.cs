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
    }
}
