using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public int AddressId { get; set; }
}
