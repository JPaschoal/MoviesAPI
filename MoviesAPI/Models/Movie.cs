using System.ComponentModel.DataAnnotations;

namespace MoviesAPI;

public class Movie
{
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Genre is required")]
    [MaxLength(50, ErrorMessage = "Genre cannot be more than 30 characters")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "Duration is required")]
    [Range(70, 600, ErrorMessage = "Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}
