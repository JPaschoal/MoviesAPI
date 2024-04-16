using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> _movies = new List<Movie>();
    private static int _id = 0;

    [HttpPost]
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        movie.Id = _id++;
        _movies.Add(movie);
        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }
    [HttpGet]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0, int take = 2)
    {
        return _movies.Skip(skip).Take(take);
    }
    [HttpGet("{id}")]
    public IActionResult GetMovie(int id)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok();
    }
}
