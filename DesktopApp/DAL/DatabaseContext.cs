using System.Data.Entity;
using DesktopApp.Models;


namespace DesktopApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base( "HephaestusDatabase" )
        {}

        public DbSet<ToolModel> Tools
        { get; set; }

        public DbSet<ServiceModel> Services
        { get; set; }

        public DbSet<OrderModel> Orders
        { get; set; }

        public DbSet<UserModel> Users
        { get; set; }
    }
}
