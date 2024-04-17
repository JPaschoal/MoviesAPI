﻿using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Address, opt => opt.MapFrom(c => c.Address));
    }
}
