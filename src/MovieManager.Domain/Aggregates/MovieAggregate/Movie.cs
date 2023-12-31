using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManager.Domain.Aggregates.MovieAggregate.ValueObjects;
using MovieManager.Domain.Common.Models;

namespace MovieManager.Domain.Aggregates.MovieAggregate
{
    public sealed class Movie : AggregateRoot<MovieId, Guid>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        private Movie(string name, string description, MovieId? id = null) : base(id ?? MovieId.CreateUnique())
        {
            Name = name;
            Description = description;
        }
        public static Movie Create(string name, string description, MovieId? id = null)
        {
            return new Movie(name, description, id);
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
        private Movie()
        {

        }
    }
}