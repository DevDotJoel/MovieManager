using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        public MovieController()
        {

        }
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok("Hello World");
        }
    }
}