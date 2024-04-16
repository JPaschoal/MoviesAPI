using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;
    public MovieController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
    {
        Movie movie = _mapper.Map<Movie>(movieDto);
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
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        _mapper.Map(movieDto, movie);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpPatch("{id}")]
    public IActionResult PartialUpdateMovie(int id, [FromBody] JsonPatchDocument<UpdateMovieDto> patchDocument)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();

        var movieDto = _mapper.Map<UpdateMovieDto>(movie);
        patchDocument.ApplyTo(movieDto, ModelState);
        if (!TryValidateModel(movieDto)) return BadRequest(ModelState);

        _mapper.Map(movieDto, movie);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        return NoContent();
    }
}
