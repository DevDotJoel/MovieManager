using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManager.Domain.Common.Models;

namespace MovieManager.Domain.Aggregates.MovieAggregate
{
    public sealed class Movie : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        private Movie(string name, string description, Guid? id) : base(id ?? Guid.NewGuid())
        {
            Name = name;
            Description = description;
        }
        public static Movie Create(string name, string description, Guid? id = null)
        {
            return new Movie(name, description, id);
        }
        private Movie()
        {

        }
    }
}