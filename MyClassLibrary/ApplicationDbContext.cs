using Microsoft.EntityFrameworkCore;
using MyClassLibrary.Models;

namespace MyClassLibrary
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ShapeResult> ShapeResults { get; set; }

        public ApplicationDbContext()
        {
            // en tom konstruktor behövs för att skapa migrations
        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=ShapesStrategy;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

    }
}
