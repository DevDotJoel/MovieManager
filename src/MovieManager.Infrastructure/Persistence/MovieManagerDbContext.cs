using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManager.Domain.Aggregates.MovieAggregate;

namespace MovieManager.Infrastructure.Persistence
{
    public class MovieManagerDbContext : DbContext
    {
        public MovieManagerDbContext(DbContextOptions<MovieManagerDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieManagerDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}