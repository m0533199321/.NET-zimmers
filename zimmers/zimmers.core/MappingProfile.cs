using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cleaner, CleanerDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Owner, OwnerDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Zimmer, ZimmerDto>().ReverseMap();
        }
    }
}
