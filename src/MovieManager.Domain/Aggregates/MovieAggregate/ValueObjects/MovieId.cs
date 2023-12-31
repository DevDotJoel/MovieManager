using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManager.Domain.Common.Models;

namespace MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects
{
    public class MovieId : AggregateRootId<Guid>
    {
        public MovieId(Guid value) : base(value)
        {

        }
        public static MovieId Create(Guid value)
        {
            return new MovieId(value);
        }
        public static MovieId CreateUnique()
        {
            return new MovieId(Guid.NewGuid());


        }
    }
}