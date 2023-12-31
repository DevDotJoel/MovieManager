using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieManager.Application.Movies.Commands.Create;
using MovieManager.Application.Movies.Commands.Queries.ListMovies;

namespace MovieManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ISender _mediator;

        public MovieController(ISender mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var command = new ListMoviesQuery();
            var movies = await _mediator.Send(command);
            return Ok(movies);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie(string name, string description)
        {
            var command = new CreateMovieCommand(name, description);
            await _mediator.Send(command);
            return Ok("");
        }
    }
}