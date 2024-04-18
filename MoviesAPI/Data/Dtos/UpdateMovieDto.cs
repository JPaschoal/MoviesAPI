using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents the data transfer object for updating a movie.
/// </summary>
public class UpdateMovieDto
{
    /// <summary>
    /// Gets or sets the title of the movie.
    /// </summary>
    [Required(ErrorMessage = "Title is required")]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the genre of the movie.
    /// </summary>
    [Required(ErrorMessage = "Genre is required")]
    [StringLength(50, ErrorMessage = "Genre cannot be more than 30 characters")]
    public string? Genre { get; set; }

    /// <summary>
    /// Gets or sets the duration of the movie in minutes.
    /// </summary>
    [Required(ErrorMessage = "Duration is required")]
    [Range(70, 600, ErrorMessage = "Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}
