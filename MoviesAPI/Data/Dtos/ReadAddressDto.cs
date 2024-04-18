using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a data transfer object for reading an address.
/// </summary>
public class ReadAddressDto
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
    public string? Street { get; set; }

    /// <summary>
    /// Gets or sets the number of the address.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// Gets or sets the city of the address.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the zip code of the address.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// Gets or sets the country of the address.
    /// </summary>
    public string? Country { get; set; }
}
