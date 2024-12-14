using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrlShortaner.Infratructure.Data.Configurations;

public class TodoItemConfiguration : IEntityTypeConfiguration<Domain.Entities.UrlShortaner>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.UrlShortaner> builder)
    {
        builder.Property(t => t.Url)
            .HasMaxLength(1000)
            .IsRequired();
        builder.Property(t => t.Code)
            .HasMaxLength(50)
            .IsRequired();
    }
}
