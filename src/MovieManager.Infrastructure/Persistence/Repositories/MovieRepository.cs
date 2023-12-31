using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Domain.Aggregates.MovieAggregate;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;

namespace MovieManager.Infrastructure.Persistence.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieManagerDbContext _dbContext;

        public MovieRepository(MovieManagerDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task AddAsync(Movie entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Movie entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Movie>> GetAllAsync()
        {
            return await _dbContext.Movies.ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(MovieId id)
        {
            return await _dbContext.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Movie entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}