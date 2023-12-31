using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManager.Domain.Aggregates.MovieAggregate;

namespace MovieManager.Application.Common.Interfaces.Persistence
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {

    }
}