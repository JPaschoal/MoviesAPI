﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

/// <summary>
/// Represents a controller for sessions.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class SessionController : ControllerBase
{
    private MovieContext _context;

    private IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionController"/> class.
    /// </summary>
    public SessionController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Get a list of sessions.
    /// </summary>
    /// <returns>A list of sessions.</returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<ReadSessionDto> GetSessions()
    {
        return _mapper.Map<List<ReadSessionDto>>(_context.Sessions);
    }

    /// <summary>
    /// Get a session by its ID.
    /// </summary>
    /// <param name="movieId">The ID of the movie.</param>
    /// <param name="cinemaId">The ID of the cinema.</param>
    /// <returns>The session with the given ID.</returns>
    [HttpGet("{movieId}/{cinemaId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetSession(int movieId, int cinemaId)
    {
        var session = _context.Sessions.FirstOrDefault(s => s.MovieId == movieId && s.CinemaId == cinemaId);
        if (session == null) return NotFound();
        var sessionDto = _mapper.Map<ReadSessionDto>(session);
        return Ok(sessionDto);
    }

    /// <summary>
    /// Create a session.
    /// </summary>
    /// <param name="sessionDto">The session to create.</param>
    [HttpPost]
    public IActionResult AddSession([FromBody] CreateSessionDto sessionDto)
    {
        Session session = _mapper.Map<Session>(sessionDto);
        _context.Sessions.Add(session);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetSession), new { movieId = session.MovieId, cinemaId = session.CinemaId }, session);
    }
}
