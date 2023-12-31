using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManager.Domain.Aggregates.MovieAggregate;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;

namespace MovieManager.Application.Common.Interfaces.Persistence
{
    public interface IMovieRepository : IBaseRepository<MovieId, Movie>
    {

    }
}