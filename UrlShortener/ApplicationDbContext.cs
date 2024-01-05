using Microsoft.EntityFrameworkCore;
using UrlShortener.Entities;

namespace UrlShortener;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<ShortenedUrl> ShortenedUrls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
    }
}