using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieManager.Domain.Aggregates.MovieAggregate;

namespace MovieManager.Infrastructure.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedNever();
        }
    }
}