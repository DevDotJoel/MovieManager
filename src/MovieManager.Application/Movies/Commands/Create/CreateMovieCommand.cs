using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MovieManager.Application.Movies.Commands.Create
{
    public record CreateMovieCommand
    (
        string Name,
        string Description
    ) : IRequest;
}