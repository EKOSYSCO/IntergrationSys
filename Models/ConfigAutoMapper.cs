using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intergration.Models
{

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {


            CreateMap<Customer, CustomerDataViewModel>()
               .ForMember(dest => dest.agemeza,  opt => opt.MapFrom(src => src.AgeLable))
               .ForMember(dest => dest.comment, opt => opt.MapFrom(src => src.Comment))
               .ForMember(dest => dest.custadd, opt => opt.MapFrom(src => src.Address))
               .ForMember(dest => dest.custtel, opt => opt.MapFrom(src => src.Telephone))
               .ForMember(dest => dest.custname, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.custage, opt => opt.MapFrom(src => src.Age))
               .ForMember(dest => dest.ename, opt => opt.MapFrom(src => src.Code))
               .ForMember(dest => dest.doctorname, opt => opt.MapFrom(src => src.DoctorName))
               .ForMember(dest => dest.sex, opt => opt.MapFrom(src => src.Gender))
               .ForMember(dest => dest.custmob, opt => opt.MapFrom(src => src.Mobile)).ReverseMap();
               
        }
    }

}
