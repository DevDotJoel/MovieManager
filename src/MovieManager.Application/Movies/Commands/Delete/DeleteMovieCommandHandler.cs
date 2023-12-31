using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;

namespace MovieManager.Application.Movies.Commands.Delete
{
    public class DeleteMovieCommandHandler : IRequestHandler<DeleteMovieCommand>
    {
        private readonly IMovieRepository _movieRepository;
        public DeleteMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _movieRepository.GetByIdAsync(MovieId.Create(request.Id));
            await _movieRepository.DeleteAsync(movie);
        }
    }
}