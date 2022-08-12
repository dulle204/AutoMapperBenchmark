using AutoMapper;

namespace AutoMapperBnechmark
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Source20, Destination20>();
            CreateMap<Source25, Destination25>();
        }
    }
}
