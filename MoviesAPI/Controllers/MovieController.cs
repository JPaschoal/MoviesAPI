using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private MovieContext _context;
    public MovieController(MovieContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }
    [HttpGet]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0, int take = 2)
    {
        return _context.Movies.Skip(skip).Take(take);
    }
    [HttpGet("{id}")]
    public IActionResult GetMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }
}
