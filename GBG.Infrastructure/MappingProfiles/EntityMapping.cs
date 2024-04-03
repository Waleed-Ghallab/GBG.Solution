using AutoMapper;
using GBG.Core.DomainModels;
using GBG.DTOs.AppDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Infrastructure.MappingProfiles
{
    public class EntityMapping : Profile
    {
        public EntityMapping() 
        {
            CreateMap<StudentDTO, Student>()
                .ForMember(x=>x.Name,x=>x.MapFrom(o=>o.Name))
                .ForMember(x=>x.Gender, x => x.MapFrom(o => o.Gender))
                .ReverseMap();
            CreateMap<CourseDTO,Course>()
                .ForMember(x => x.Name, x => x.MapFrom(o => o.Name))
                .ForMember(x => x.Description, x => x.MapFrom(o => o.Description))
                .ReverseMap();
        }
    }
}
