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
    /// Configures the movie context.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Session>().HasKey(s => new { s.MovieId, s.CinemaId });

        builder.Entity<Session>()
            .HasOne(s => s.Cinema) // tem um cinema
            .WithMany(c => c.Sessions) // tem muitas sessões
            .HasForeignKey(s => s.CinemaId); // fk de movie
        builder.Entity<Session>()
            .HasOne(s => s.Movie) // tem um filme
            .WithMany(m => m.Sessions) // tem muitas sessões
            .HasForeignKey(s => s.MovieId); // fk de movie
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
    /// <summary>
    /// Gets or sets the sessions DbSet.
    /// </summary>
    public DbSet<Session> Sessions { get; set; }
}
