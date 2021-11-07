using Microsoft.EntityFrameworkCore;
using ProgLibrary.Core.Domain;

namespace ProgLibrary.Core.DAL
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers", t => t.ExcludeFromMigrations());


        }

    }
}
