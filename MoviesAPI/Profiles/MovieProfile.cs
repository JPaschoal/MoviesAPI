﻿using AutoMapper;
using MoviesAPI.Models;

namespace MoviesAPI;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
    }

}