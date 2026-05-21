using Microsoft.EntityFrameworkCore;
using DC.Models;

namespace DC.Contexts;

public class DCContext(DbContextOptions<DCContext> options) : DbContext(options)
{
    public DbSet<Hero> Heroes {get;set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Hero>()
            .HasKey(t => t.Id);
        builder.Entity<Hero>()
            .Property(t => t.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();
        builder.Entity<Hero>()
            .Property(t => t.DisabledAt)
            .HasColumnName("disabled_at");
        builder.Entity<Hero>()
            .Property(t => t.UpdatedAt)
            .HasColumnName("updated_at")
            .IsRequired();

        builder.Entity<Hero>()
            .Property(t => t.Name)
            .HasMaxLength(255)
            .IsRequired();
        builder.Entity<Hero>()
            .Property(t => t.Description)
            .HasMaxLength(255)
            .IsRequired();
        builder.Entity<Hero>()
            .Property(t => t.Power)
            .HasMaxLength(255)
            .IsRequired();
        builder.Entity<Hero>()
            .Property(t => t.Status)
            .HasMaxLength(255)
            .IsRequired();
    }
}