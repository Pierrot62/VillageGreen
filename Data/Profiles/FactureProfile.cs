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
    class FactureProfile : Profile
    {
        public FactureProfile()
        {
            CreateMap<FactureDTOIn, Facture>();
            CreateMap<Facture, FactureDTOIn>();
            CreateMap<Facture, FactureDTOOut>()
                .ForMember(d => d.TypePaiement, o => o.MapFrom(s => s.Reglement.TypePaiement))
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
                .ForMember(d => d.DateCommande, o => o.MapFrom(s => s.Commande.DateCommande));
            CreateMap<FactureDTOOut, Facture>();
                }
    }
}
