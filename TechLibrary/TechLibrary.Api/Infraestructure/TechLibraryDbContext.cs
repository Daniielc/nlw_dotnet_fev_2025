using Microsoft.EntityFrameworkCore;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure
{
    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-TIG0F3F\\MSSQLSERVER01;Database=TechLibraryDb;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Daniel Chaves\\source\\repos\\NLW\\TechLibrary\\TechLibraryDb.db");
        }
    }
}
