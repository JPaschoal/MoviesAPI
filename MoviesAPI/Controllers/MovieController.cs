using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> _movies = new List<Movie>();

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        _movies.Add(movie);
    }
    [HttpGet]
    public IEnumerable<Movie> GetMovies()
    {
        return _movies;
    }
}
