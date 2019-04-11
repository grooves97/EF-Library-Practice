using System.Data.Entity;
using EFLibrary.Models;

namespace EFLibrary.DataAcces
{
    public class AppContext : DbContext
    {
        public AppContext() : base("appContext")
        {}

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
