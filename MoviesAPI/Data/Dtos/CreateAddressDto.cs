using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a data transfer object for creating an address.
/// </summary>
public class CreateAddressDto
{
    /// <summary>
    /// The street of the address.
    /// </summary>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// The number of the address.
    /// </summary>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// The city of the address.
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// The zip code of the address.
    /// </summary>
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// The country of the address.
    /// </summary>
    public string Country { get; set; } = string.Empty;
}
