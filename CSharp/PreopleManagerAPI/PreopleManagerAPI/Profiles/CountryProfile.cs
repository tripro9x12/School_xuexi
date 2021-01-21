using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models.Entities;

namespace PreopleManagerAPI.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<CreateCountryDto, Country>();
            CreateMap<Country, ReadCountryDto>();
            CreateMap<UpdateCountryDto, Country>();
        }
    }
}
