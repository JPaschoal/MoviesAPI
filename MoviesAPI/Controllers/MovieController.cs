using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

/// <summary>
/// Represents the movie controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;
    /// <summary>
    /// Initializes a new instance of the <see cref="MovieController"/> class.
    /// </summary>
    public MovieController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Add a movie to the database
    /// </summary>
    /// <param name="movieDto">The movie to add</param>
    /// <returns>The movie that was added</returns>
    /// <response code="201">Returns the newly created movie</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
    {
        Movie movie = _mapper.Map<Movie>(movieDto);
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }
    /// <summary>
    /// Get a list of movies
    /// </summary>
    /// <param name="skip">The number of movies to skip</param>
    /// <param name="take">The number of movies to take</param>
    /// <returns>A list of movies</returns>
    /// <response code="200">Returns the list of movies</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<ReadMovieDto> GetMovies([FromQuery] int skip = 0, int take = 2)
    {
        return _mapper.Map<List<ReadMovieDto>>(_context.Movies.Skip(skip).Take(take).ToList());
    }
    /// <summary>
    /// Get a movie by its ID
    /// </summary>
    /// <param name="id">The ID of the movie</param>
    /// <returns>The movie with the given ID</returns>
    /// <response code="200">Returns the movie</response>
    /// <response code="404">If the movie is not found</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }
        var movieDto = _mapper.Map<ReadMovieDto>(movie);
        return Ok(movieDto);
    }
    /// <summary>
    /// Update a movie
    /// </summary>
    /// <param name="id">The ID of the movie</param>
    /// <param name="movieDto">The updated movie</param>
    /// <returns>No content</returns>
    /// <response code="204">If the movie was updated successfully</response>
    /// <response code="404">If the movie is not found</response>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        _mapper.Map(movieDto, movie);
        _context.SaveChanges();
        return NoContent();
    }
    /// <summary>
    /// Partially update a movie
    /// </summary>
    /// <param name="id">The ID of the movie</param>
    /// <param name="patchDocument">The patch document</param>
    /// <returns>No content</returns>
    /// <response code="204">If the movie was updated successfully</response>
    /// <response code="404">If the movie is not found</response>
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
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
    /// <summary>
    /// Delete a movie
    /// </summary>
    /// <param name="id">The ID of the movie</param>
    /// <returns>No content</returns>
    /// <response code="204">If the movie was deleted successfully</response>
    /// <response code="404">If the movie is not found</response>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        return NoContent();
    }
}
