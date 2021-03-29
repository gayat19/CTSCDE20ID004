using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ShowContext _context;

        public MovieController(ShowContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            try
            {
                List<Movie> movies = await _context.Movies.ToListAsync();
                return Ok(movies);
            }
            catch (Exception e)
            {

                return BadRequest("Exception..." + e.Message);
            }
            //return BadRequest("Exception..." );
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> Post(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest("Exception..." + e.Message);
            }

            return Ok(movie);
          
        }
    }
}
