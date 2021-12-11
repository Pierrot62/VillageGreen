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
    class LigneCommandeProfile : Profile
    {
        public LigneCommandeProfile()
        {
            CreateMap<LigneCommandeDTOIn, LigneCommande>();
            CreateMap<LigneCommande, LigneCommandeDTOIn>();
            CreateMap<LigneCommande, LigneCommandeDTOOut>()
                .ForMember(d => d.RefProduit, o => o.MapFrom(s => s.Produit.RefProduit))
                .ForMember(d => d.LibelleProduit, o => o.MapFrom(s => s.Produit.LibelleProduit))
                .ForMember(d => d.PrixHorsTaxes, o => o.MapFrom(s => s.Produit.PrixHorsTaxes))
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
                .ForMember(d => d.DateCommande, o => o.MapFrom(s => s.Commande.DateCommande));
            CreateMap<LigneCommandeDTOOut, LigneCommande>();
        }
    }
}
