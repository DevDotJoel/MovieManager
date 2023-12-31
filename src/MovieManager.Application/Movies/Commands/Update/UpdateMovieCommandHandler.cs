using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MovieManager.Application.Common.Interfaces.Persistence;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;

namespace MovieManager.Application.Movies.Commands.Update
{
    public class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand>
    {
        private readonly IMovieRepository _movieRepository;
        public UpdateMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;

        }

        public async Task Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _movieRepository.GetByIdAsync(MovieId.Create(request.Id));
            movie.SetName(request.Name);
            movie.SetDescription(request.Description);
            await _movieRepository.UpdateAsync(movie);

        }
    }
}