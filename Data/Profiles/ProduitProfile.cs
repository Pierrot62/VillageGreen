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
    class ProduitProfile : Profile
    {
        public ProduitProfile()
        {
            CreateMap<ProduitDTOIn, Produit>();
            CreateMap<Produit, ProduitDTOIn>();
            CreateMap<Produit, ProduitDTOOut>()
                .ForMember(d => d.LibelleRubrique, o => o.MapFrom(s => s.Rubrique.LibelleRubrique));
            CreateMap<ProduitDTOOut, Produit>();
        }
    }
}
