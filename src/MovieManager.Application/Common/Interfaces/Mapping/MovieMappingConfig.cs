using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using MovieManager.Application.Common.Models.Movie;
using MovieManager.Domain.Aggregates.MovieAggregate;

namespace MovieManager.Application.Common.Interfaces.Mapping
{
    public class MovieMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Movie, MovieModel>();
        }
    }
}