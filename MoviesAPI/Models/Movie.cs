using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

/// <summary>
/// Represents a movie.
/// </summary>
public class Movie
{
    /// <summary>
    /// Gets or sets the movie ID.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the movie title.
    /// </summary>
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the movie genre.
    /// </summary>
    [Required(ErrorMessage = "Genre is required")]
    [MaxLength(50, ErrorMessage = "Genre cannot be more than 30 characters")]
    public string Genre { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the movie duration in minutes.
    /// </summary>
    [Required(ErrorMessage = "Duration is required")]
    [Range(70, 600, ErrorMessage = "Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; } = 0;
}
