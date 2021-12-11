using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Dtos;
using VillageGreen.Data.Models;

namespace VillageGreen.Data
{
    class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTOIn, User>();
            CreateMap<User, UserDTOIn>();
            CreateMap<User, UserDTOOut>()
                .ForMember(d => d.LibelleRole, o => o.MapFrom(s => s.Role.LibelleRole));
            CreateMap<UserDTOOut, User>();
        }
    }
}
