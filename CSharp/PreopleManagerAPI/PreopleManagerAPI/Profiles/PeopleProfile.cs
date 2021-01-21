using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models.Entities;

namespace PreopleManagerAPI.Profiles
{
    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            CreateMap<CreatePeopleDto, People>();
            CreateMap<UpdatePeopleDto, People>();
        }
    }
}
