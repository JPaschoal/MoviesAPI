using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
    /// <summary>
    /// Represents a profile for mapping Session entities.
    /// </summary>
    public class SessionProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionProfile"/> class.
        /// </summary>
        public SessionProfile()
        {
            CreateMap<Session, ReadSessionDto>();
            CreateMap<CreateSessionDto, Session>();
        }
    }
}
