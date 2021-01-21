using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CommanderAPI.Models;
using CommanderAPI.Dtos;

namespace CommanderAPI.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
