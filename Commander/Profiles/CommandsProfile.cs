using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommanderProfile : Profile
    {
        public CommanderProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
    
}