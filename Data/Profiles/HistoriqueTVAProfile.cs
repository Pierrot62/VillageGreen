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
    class HistoriqueTVAProfile : Profile
    {
        public HistoriqueTVAProfile()
        {
            CreateMap<HistoriqueTVADTOIn, HistoriqueTVA>();
            CreateMap<HistoriqueTVA, HistoriqueTVADTOIn>();
            CreateMap<HistoriqueTVA, HistoriqueTVADTOOut>()
                .ForMember(d => d.LibelleProduit, o => o.MapFrom(s => s.Produit.LibelleProduit))
                .ForMember(d => d.RefProduit, o => o.MapFrom(s => s.Produit.RefProduit))
                .ForMember(d => d.LibelleRubrique, o => o.MapFrom(s => s.Produit.Rubrique.LibelleRubrique));
            CreateMap<HistoriqueTVADTOOut, HistoriqueTVA>();
                }
    }
}
