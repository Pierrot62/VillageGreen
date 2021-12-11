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
    class CategorieClientProfile : Profile
    {
        public CategorieClientProfile()
        {
            CreateMap<CategorieClientDTOIn, CategorieClient>();
            CreateMap<CategorieClient, CategorieClientDTOIn>();
            CreateMap<CategorieClient, CategorieClientDTOOut>();
            CreateMap<CategorieClientDTOOut, CategorieClient>();
        }
    }
}
