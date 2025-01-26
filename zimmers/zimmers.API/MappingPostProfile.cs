using AutoMapper;
using zimmers.API.PostModels;
using zimmers.core.DTOs;

namespace zimmers.API
{
    public class MappgingPostProfile : Profile
    {
        public MappgingPostProfile()
        {
            CreateMap<CleanerPostModel, CleanerDto>();
            CreateMap<OrderPostModel, OrderDto>();
            CreateMap<OwnerPostModel, OwnerDto>();
            CreateMap<UserPostModel, UserDto>();
            CreateMap<ZimmerPostModel, ZimmerDto>();
        }
    }
}
