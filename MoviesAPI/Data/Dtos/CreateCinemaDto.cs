using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents the data transfer object for creating a cinema.
/// </summary>
public class CreateCinemaDto
{
    /// <summary>
    /// Gets or sets the name of the cinema.
    /// </summary>
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ID of the address associated with the cinema.
    /// </summary>
    public int? AddressId { get; set; }
}
