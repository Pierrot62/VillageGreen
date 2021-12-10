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
                .ForMember(d => d.IdVille, o => o.MapFrom(s => s.Ville.IdVille))
                .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Ville.LibelleVille))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Ville.CodePostal))
                .ForMember(d => d.IdPays, o => o.MapFrom(s => s.Pays.IdPays))
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Pays.NomPays));
            CreateMap<AdresseDTOOut, Adresse>();
                }
    }
}
