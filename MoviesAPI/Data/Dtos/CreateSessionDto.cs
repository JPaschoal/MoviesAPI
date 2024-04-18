namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a session DTO.
/// </summary>
public class CreateSessionDto
{
    /// <summary>
    /// Gets or sets the session movie ID.
    /// </summary>
    public int MovieId { get; set; }
    /// <summary>
    /// Gets or sets the session cinema ID.
    /// </summary>
    public int CinemaId { get; set; }
}
