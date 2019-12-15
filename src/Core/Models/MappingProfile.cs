using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Core.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Bike, Bike>();
            CreateMap<Bike, Entities.Bike>();
            CreateMap<Entities.Brand, Brand>();
            CreateMap<Brand, Entities.Brand>();
        }
    }
}
