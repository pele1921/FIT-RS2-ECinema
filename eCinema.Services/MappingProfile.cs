using AutoMapper;

namespace eCinema.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.Movie, Model.Movie>();
        }

    }
}
