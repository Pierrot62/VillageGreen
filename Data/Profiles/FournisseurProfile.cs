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
    class FournisseurProfile : Profile
    {
        public FournisseurProfile()
        {
            CreateMap<FournisseurDTOIn, Fournisseur>();
            CreateMap<Fournisseur, FournisseurDTOIn>();
            CreateMap<Fournisseur, FournisseurDTOOut>();
            CreateMap<FournisseurDTOOut, Fournisseur>();
                }
    }
}
