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
    class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<ClientDTOIn, Client>();
            CreateMap<Client, ClientDTOIn>();
            CreateMap<Client, ClientDTOOut>()
                .ForMember(d => d.LibelleCategClient, o => o.MapFrom(s => s.CategorieClient.LibelleCategClient));
            CreateMap<ClientDTOOut, Client>();
        }
    }
}
