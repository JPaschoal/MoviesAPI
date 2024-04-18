using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

/// <summary>
/// Represents the controller for managing cinemas.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CinemaController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;
    /// <summary>
    /// Initializes a new instance of the <see cref="CinemaController"/> class.
    /// </summary>
    public CinemaController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Add a cinema to the database
    /// </summary>
    /// <param name="cinemaDto">The cinema to add</param>
    /// <returns>The cinema that was added</returns>
    /// <response code="201">Returns the newly created cinema</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AddCinema([FromBody] CreateCinemaDto cinemaDto)
    {
        Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
        _context.Cinemas.Add(cinema);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetCinema), new { id = cinema.Id }, cinema);
    }
    /// <summary>
    /// Get a list of cinemas
    /// </summary>
    /// <param name="skip">The number of cinemas to skip</param>
    /// <param name="take">The number of cinemas to take</param>
    /// <returns>A list of cinemas</returns>
    /// <response code="200">Returns the list of cinemas</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<ReadCinemaDto> GetCinemas([FromQuery] int skip = 0, int take = 2)
    {
        return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.Skip(skip).Take(take).ToList());
    }
    /// <summary>
    /// Get a cinema by its ID
    /// </summary>
    /// <param name="id">The ID of the cinema</param>
    /// <returns>The cinema with the given ID</returns>
    /// <response code="200">Returns the cinema</response>
    /// <response code="404">If the cinema is not found</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetCinema(int id)
    {
        var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);
        if (cinema == null) return NotFound();
        var cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
        return Ok(cinemaDto);
    }
    /// <summary>
    /// Update a cinema
    /// </summary>
    /// <param name="id">The ID of the cinema</param>
    /// <param name="cinemaDto">The updated cinema</param>
    /// <returns>The updated cinema</returns>
    /// <response code="200">Returns the updated cinema</response>
    /// <response code="404">If the cinema is not found</response>
    [HttpPut("{id}")]
    public IActionResult UpdateCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
    {
        var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);
        if (cinema == null) return NotFound();
        _mapper.Map(cinemaDto, cinema);
        _context.SaveChanges();
        return NoContent();
    }
    /// <summary>
    /// Delete a cinema
    /// </summary>
    /// <param name="id">The ID of the cinema</param>
    /// <returns>No content</returns>
    /// <response code="204">No content</response>
    /// <response code="404">If the cinema is not found</response>
    [HttpDelete("{id}")]
    public IActionResult DeleteCinema(int id)
    {
        var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);
        if (cinema == null) return NotFound();
        _context.Cinemas.Remove(cinema);
        _context.SaveChanges();
        return NoContent();
    }
}
