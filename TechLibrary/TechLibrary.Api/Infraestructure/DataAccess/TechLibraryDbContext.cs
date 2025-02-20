using Microsoft.EntityFrameworkCore;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.DataAccess
{
    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-TIG0F3F\\MSSQLSERVER01;Database=TechLibraryDb;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Daniel Chaves\\source\\repos\\NLW\\TechLibrary\\TechLibraryDb.db");
            //optionsBuilder.UseSqlite("Data Source=C:\\Users\\dsilva\\OneDrive - Nepreconsulting\\Desktop\\NLW\\nlw_dotnet_fev_2025\\TechLibrary\\TechLibraryDb.db");
        }
    }
}
