namespace MoviesAPI.Data.Dtos;

/// <summary>
/// Represents a data transfer object for reading a movie.
/// </summary>
public class ReadMovieDto
{
    /// <summary>
    /// Gets or sets the title of the movie.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the genre of the movie.
    /// </summary>
    public string? Genre { get; set; }

    /// <summary>
    /// Gets or sets the duration of the movie in minutes.
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// Gets or sets the query time of the movie.
    /// </summary>
    public DateTime QueryTime { get; set; } = DateTime.Now;
    /// <summary>
    /// Gets or sets the session associated with the movie.
    /// </summary>
    public ICollection<ReadSessionDto>? Session { get; set; }
}
