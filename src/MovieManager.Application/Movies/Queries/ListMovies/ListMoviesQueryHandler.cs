using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsterMapper;
using MediatR;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Application.Common.Models.Movie;

namespace MovieManager.Application.Movies.Commands.Queries.ListMovies
{
    public record ListMoviesQueryHandler : IRequestHandler<ListMoviesQuery, List<MovieModel>>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public ListMoviesQueryHandler(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<List<MovieModel>> Handle(ListMoviesQuery request, CancellationToken cancellationToken)
        {
            var movies = _mapper.Map<List<MovieModel>>(await _movieRepository.GetAllAsync());
            return movies;
        }
    }
}