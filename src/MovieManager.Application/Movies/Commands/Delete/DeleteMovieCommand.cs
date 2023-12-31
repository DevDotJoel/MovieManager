using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MovieManager.Application.Movies.Commands.Delete
{
    public record DeleteMovieCommand(Guid Id) : IRequest;
}