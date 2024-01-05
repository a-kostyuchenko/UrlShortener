using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrlShortener.Entities;
using UrlShortener.Services;

namespace UrlShortener.Configurations;

internal sealed class ShortenedUrlConfiguration 
    : IEntityTypeConfiguration<ShortenedUrl>
{
    public void Configure(EntityTypeBuilder<ShortenedUrl> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Code).HasMaxLength(UrlShorteningService.NumberOfCharsInShortLink);

        builder.HasIndex(s => s.Code).IsUnique();
    }
}