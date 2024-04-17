using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
}
