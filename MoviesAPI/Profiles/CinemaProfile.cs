using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

/// <summary>
/// Represents the profile for mapping Cinema entities.
/// </summary>
public class CinemaProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CinemaProfile"/> class.
    /// </summary>
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Address, opt => opt.MapFrom(c => c.Address));
    }
}
