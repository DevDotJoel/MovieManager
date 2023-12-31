using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManager.Contracts.Movies
{
    public record CreateUpdateMovieRequest
    (
        string Id,
        string Name,
        string Description
    );
}