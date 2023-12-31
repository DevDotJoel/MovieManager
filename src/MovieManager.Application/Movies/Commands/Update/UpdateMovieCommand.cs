using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MovieManager.Application.Movies.Commands.Update
{
    public record UpdateMovieCommand
    (
        Guid Id,
        string Name,
        string Description
    ) : IRequest;
}