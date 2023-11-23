using FirstDbProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstDbProject.Persistense.DataContexts;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    public DbSet<Author> Authors => Set<Author>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FirstDbProject;Username=postgres;Password=admin");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book> ().HasOne(book => book.Author).WithMany();
    }
}
