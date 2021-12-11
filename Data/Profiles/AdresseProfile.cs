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
    class AdresseProfile : Profile
    {
        public AdresseProfile()
        {
            CreateMap<AdresseDTOIn, Adresse>();
            CreateMap<Adresse, AdresseDTOIn>();
            CreateMap<Adresse, AdresseDTOOut>()
                .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Ville.LibelleVille))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Ville.CodePostal))
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Ville.Pays.NomPays));
            CreateMap<AdresseDTOOut, Adresse>();
                }
    }
}
