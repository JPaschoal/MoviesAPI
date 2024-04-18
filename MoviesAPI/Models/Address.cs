using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

/// <summary>
/// Represents an address.
/// </summary>
public class Address
{
    /// <summary>
    /// Gets or sets the ID of the address.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the street of the address.
    /// </summary>
    [Required(ErrorMessage = "The field Street is required")]
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the number of the address.
    /// </summary>
    [Required(ErrorMessage = "The field Number is required")]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the city of the address.
    /// </summary>
    [Required(ErrorMessage = "The field City is required")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the zip code of the address.
    /// </summary>
    [Required(ErrorMessage = "The field ZipCode is required")]
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the country of the address.
    /// </summary>
    [Required(ErrorMessage = "The field Country is required")]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the cinema associated with the address.
    /// </summary>
    public virtual Cinema? Cinema { get; set; }
}
