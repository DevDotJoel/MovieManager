using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Domain.Aggregates.MovieAggregate;

namespace MovieManager.Application.Movies.Commands.Create
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand>
    {
        private readonly IMovieRepository _movieRepository;
        public CreateMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;

        }
        public async Task Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = Movie.Create(request.Name, request.Description);
            await _movieRepository.AddAsync(movie);

        }
    }
}