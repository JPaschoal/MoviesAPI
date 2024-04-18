using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

/// <summary>
/// Represents a cinema.
/// </summary>
public class Cinema
{
    /// <summary>
    /// Gets or sets the ID of the cinema.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the cinema.
    /// </summary>
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ID of the address associated with the cinema.
    /// </summary>
    public int AddressId { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the cinema.
    /// </summary>
    public virtual Address? Address { get; set; }
}
