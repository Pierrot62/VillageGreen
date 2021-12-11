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
    class EtatCommmandeProfile : Profile
    {
        public EtatCommmandeProfile()
        {
            CreateMap<EtatCommandeDTOIn, EtatCommande>();
            CreateMap<EtatCommande, EtatCommandeDTOIn>();

            CreateMap<EtatCommande, EtatCommandeDTOOut>();
            CreateMap<EtatCommandeDTOOut, EtatCommande>();
        }
    }
}
