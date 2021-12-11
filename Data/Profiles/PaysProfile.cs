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
    class PaysProfile : Profile
    {
        public PaysProfile()
        {
            CreateMap<PaysDTOIn, Pays>();
            CreateMap<Pays, PaysDTOIn>();
            CreateMap<Pays, PaysDTOOut>();
            CreateMap<PaysDTOOut, Pays>();
        }
    }
}
