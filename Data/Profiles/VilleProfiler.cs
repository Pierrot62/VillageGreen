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
    class VilleProfile : Profile
    {
        public VilleProfile()
        {
            CreateMap<VilleDTOIn, Ville>();
            CreateMap<Ville, VilleDTOIn>();
            CreateMap<Ville, VilleDTOOut>()
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Pays.NomPays));
            CreateMap<VilleDTOOut, Ville>();
        }
    }
}
