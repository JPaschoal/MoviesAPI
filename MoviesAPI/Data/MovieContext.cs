using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data;

/// <summary>
/// Represents the database context for movies.
/// </summary>
public class MovieContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MovieContext"/> class.
    /// </summary>
    /// <param name="options">The options for configuring the movie context.</param>
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {

    }

    /// <summary>
    /// Gets or sets the movies DbSet.
    /// </summary>
    public DbSet<Movie> Movies { get; set; }

    /// <summary>
    /// Gets or sets the cinemas DbSet.
    /// </summary>
    public DbSet<Cinema> Cinemas { get; set; }

    /// <summary>
    /// Gets or sets the addresses DbSet.
    /// </summary>
    public DbSet<Address> Addresses { get; set; }
}
