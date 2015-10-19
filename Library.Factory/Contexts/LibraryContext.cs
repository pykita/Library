using System.Data.Entity;
using Library.Factory.Models;

namespace Library.Factory.Contexts
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
