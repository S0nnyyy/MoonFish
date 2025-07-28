using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasKey(t => t.Id);
            modelBuilder.Entity<TodoItem>().Property(t => t.Title).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<TodoItem>().Property(t => t.Description).HasMaxLength(500);
            modelBuilder.Entity<TodoItem>().Property(t => t.CreatedAt).IsRequired();
            modelBuilder.Entity<TodoItem>().Property(t => t.CompletedAt).IsRequired(false);
        }
    }
}
