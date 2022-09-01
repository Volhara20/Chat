using AutoMapper;
using Chat.Models;
using Chat.Models.DboModels;

namespace Chat.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<User, AppUser>().ReverseMap();
            CreateMap<Group, AppGroup>().ReverseMap();
            CreateMap<Message, AppMessage>().ReverseMap();
        }
    }
}
