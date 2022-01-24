using AutoMapper;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;

namespace MyWebSite.AutoMapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Message, MessageViewModel>();
            CreateMap<MessageViewModel, Message>();
        }
    }
}
