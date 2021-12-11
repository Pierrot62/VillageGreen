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
    class ProgressionCommandeProfile : Profile
    {
        public ProgressionCommandeProfile()
        {
            CreateMap<ProgressionCommandeDTOIn, ProgressionCommande>();
            CreateMap<ProgressionCommande, ProgressionCommandeDTOIn>();
            CreateMap<ProgressionCommande, ProgressionCommandeDTOOut>()
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande));
            CreateMap<ProgressionCommandeDTOOut, ProgressionCommande>();
        }
    }
}
