using Microsoft.EntityFrameworkCore;

namespace N28_Project.DataLayer;

internal class EfCoreContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder.UseNpgsql
        ("Server=localhost;Port=5432;UserName=admin;Database=postgres;Password=admin");
}
