namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a session DTO.
/// </summary>
public class ReadSessionDto
{
    /// <summary>
    /// Gets or sets the Movie ID.
    /// </summary>
    public int MovieId { get; set; }
    /// <summary>
    /// Gets or sets the Cinema ID.
    /// </summary>
    public int CinemaId { get; set; }
}
