using AutoMapper;
using CustomerData.Application.Features.Categories.Commands.CreateCategory;
using CustomerData.Application.Features.Categories.Commands.UpdateCategory;
using CustomerData.Application.Features.Categories.Queries.GetCategoriesList;
using CustomerData.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using CustomerData.Application.Features.Events.Commands.CreateEvent;
using CustomerData.Application.Features.Events.Commands.UpdateEvent;
using CustomerData.Application.Features.Events.Queries.GetEventDetail;
using CustomerData.Application.Features.Events.Queries.GetEventsExport;
using CustomerData.Application.Features.Events.Queries.GetEventsList;
using CustomerData.Domain.Entities;

namespace CustomerData.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // For events
            CreateMap<Event, AccountsListVm>()
                .ForMember(dest =>
                        dest.EventId,
                        opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<Event, CreateTransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>()
                 .ForMember(dest =>
                        dest.EventId,
                        opt => opt.MapFrom(src => src.Id))
                 .ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            // For Categories
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>()
                   .ForMember(dest =>
                        dest.CategoryId,
                        opt => opt.MapFrom(src => src.Id));
            CreateMap<Category, CategoryEventListVm>()
                .ForMember(dest =>
                       dest.CategoryId,
                        opt => opt.MapFrom(src => src.Id));
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>()
                  .ForMember(dest =>
                       dest.CategoryId,
                        opt => opt.MapFrom(src => src.Id));
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        }
    }
}