using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents the data transfer object for updating a cinema.
/// </summary>
public class UpdateCinemaDto
{
    /// <summary>
    /// Gets or sets the name of the cinema.
    /// </summary>
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }
}
