using AutoMapper;
using MyWebSite.Data.Models;
using MyWebSite.Data.ViewModels;

namespace MyWebSite.AutoMapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CV, CvViewModel>();
            CreateMap<CvViewModel, CV>();

            CreateMap<Image, ImageViewModel>();
            CreateMap<ImageViewModel, Image>();

            CreateMap<Message, MessageViewModel>();
            CreateMap<MessageViewModel, Message>();

            CreateMap<Project, ProjectViewModel>();
            CreateMap<ProjectViewModel, Project>();

            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderViewModel, Order>();
        }
    }
}
