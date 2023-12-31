using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MovieManager.Application.Common.Models.Movie;

namespace MovieManager.Application.Movies.Commands.Queries.ListMovies
{
    public record ListMoviesQuery() : IRequest<List<MovieModel>>;
}