using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieManager.Application.Movies.Commands.Create;
using MovieManager.Application.Movies.Commands.Delete;
using MovieManager.Application.Movies.Commands.Queries.ListMovies;
using MovieManager.Application.Movies.Commands.Update;
using MovieManager.Contracts.Movies;

namespace MovieManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public MovieController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var command = new ListMoviesQuery();
            var movies = await _mediator.Send(command);
            return Ok(movies);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateUpdateMovieRequest createMovie)
        {
            var command = _mapper.Map<CreateMovieCommand>(createMovie);
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMovie([FromBody] CreateUpdateMovieRequest updateMovie)
        {
            var command = _mapper.Map<UpdateMovieCommand>(updateMovie);
            await _mediator.Send(command);
            return Ok("");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(string id)
        {
            var command = new DeleteMovieCommand(Guid.Parse(id));
            await _mediator.Send(command);
            return Ok("");
        }
    }
}