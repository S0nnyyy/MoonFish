using Microsoft.EntityFrameworkCore;

namespace Ukol9
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Models.Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Person>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Models.Person>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder.Entity<Models.Person>()
                .Property(p => p.LastName)
                .IsRequired();
            modelBuilder.Entity<Models.Person>()
                .Property(p => p.Email)
                .IsRequired();
            modelBuilder.Entity<Models.Person>()
                .Property(p => p.PhoneNumber)
                .IsRequired();
        }



    }
}
