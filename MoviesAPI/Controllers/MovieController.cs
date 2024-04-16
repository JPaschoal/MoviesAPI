using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> _movies = new List<Movie>();
    private static int _id = 0;

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        movie.Id = _id++;
        _movies.Add(movie);
    }
    [HttpGet]
    public IEnumerable<Movie> GetMovies()
    {
        return _movies;
    }
    [HttpGet("{id}")]
    public Movie? GetMovie(int id)
    {
        return _movies.FirstOrDefault(m => m.Id == id);
    }
}
