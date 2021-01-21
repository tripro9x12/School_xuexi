using AutoMapper;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AppUser, ReadAccountDto>();
        }
    }
}
