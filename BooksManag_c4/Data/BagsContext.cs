using Microsoft.EntityFrameworkCore;
using BooksManag_c4.Models;

namespace BooksManag_c4.Data
{
    public class BagsContext : DbContext
    {
        public BagsContext(DbContextOptions<BagsContext> options)
            : base(options)
        {
        }

        public DbSet<Bags> Bags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bags>().Property(b => b.Price).HasColumnType("decimal(18,2)");
        }
    }
}

