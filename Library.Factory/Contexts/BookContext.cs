using System.Data.Entity;
using Library.Factory.Models;

namespace Library.Factory.Contexts
{
    internal class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    } 
}
