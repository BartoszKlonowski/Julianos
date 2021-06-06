using System.Data.Entity;
using DesktopApp.Models;


namespace DesktopApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base( "JulianosDatabase" )
        {}

        public DbSet<UserModel> Users
        { get; set; }

        public DbSet<BookModel> Books
        { get; set; }
    }
}
