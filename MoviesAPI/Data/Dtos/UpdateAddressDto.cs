using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents the data transfer object for updating an address.
/// </summary>
public class UpdateAddressDto
{
    /// <summary>
    /// Gets or sets the street.
    /// </summary>
    [Required(ErrorMessage = "The field Street is required")]
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the number.
    /// </summary>
    [Required(ErrorMessage = "The field Number is required")]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [Required(ErrorMessage = "The field City is required")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the zip code.
    /// </summary>
    [Required(ErrorMessage = "The field ZipCode is required")]
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [Required(ErrorMessage = "The field Country is required")]
    public string Country { get; set; } = string.Empty;
}
