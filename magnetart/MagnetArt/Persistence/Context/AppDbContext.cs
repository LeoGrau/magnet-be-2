using magnetart.MagnetArt.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace magnetart.MagnetArt.Persistence.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Provider> Providers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Author>().ToTable("authors");
        builder.Entity<Author>().HasKey(author => author.id);
        builder.Entity<Author>().Property(author => author.id).IsRequired();
        
        builder.Entity<Author>().ToTable("providers");
        builder.Entity<Author>().HasKey(provider => provider.id);
        builder.Entity<Author>().Property(provider => provider.id).IsRequired();
    }
}