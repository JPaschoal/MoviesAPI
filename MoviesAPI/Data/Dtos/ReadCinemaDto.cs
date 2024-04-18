namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a data transfer object for reading a cinema.
/// </summary>
public class ReadCinemaDto
{
    /// <summary>
    /// Gets or sets the ID of the cinema.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the cinema.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the address of the cinema.
    /// </summary>
    public ReadAddressDto? Address { get; set; }
}
