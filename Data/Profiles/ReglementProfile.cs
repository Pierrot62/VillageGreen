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
    class ReglementProfile : Profile
    {
        public ReglementProfile()
        {
            CreateMap<ReglementDTOIn, Reglement>();
            CreateMap<Reglement, ReglementDTOIn>();
            CreateMap<Reglement, ReglementDTOOut>();
            CreateMap<ReglementDTOOut, Reglement>();
        }
    }
}
