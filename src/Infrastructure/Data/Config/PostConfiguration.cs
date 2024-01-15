using Core.Entities.PostAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(256);
        }
    }
}
