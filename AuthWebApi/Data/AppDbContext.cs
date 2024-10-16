using Microsoft.EntityFrameworkCore;

using AuthWebApi.Entities;

namespace AuthWebApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) => Database.Migrate();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseIdentityColumns();
        modelBuilder.HasDefaultSchema("public");

        modelBuilder.Entity<User>();

        base.OnModelCreating(modelBuilder);
    }
}