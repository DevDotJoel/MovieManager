using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieManager.Domain.Aggregates.MovieAggregate;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;

namespace MovieManager.Infrastructure.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).HasConversion(id => id.Value, value => MovieId.Create(value)).ValueGeneratedNever();
        }
    }
}