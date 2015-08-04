using System.Data.Entity;
using Library.Factory.Models;

namespace Library.Factory.Contexts
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}