using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

/// <summary>
/// Represents a profile for mapping movie data transfer objects.
/// </summary>
public class MovieProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MovieProfile"/> class.
    /// </summary>
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, UpdateMovieDto>();
        CreateMap<Movie, ReadMovieDto>();
    }
}
