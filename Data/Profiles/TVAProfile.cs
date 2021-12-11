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
    class TvaProfile : Profile
    {
        public TvaProfile()
        {
            CreateMap<TvaDTOIn, TVA>();
            CreateMap<TVA, TvaDTOIn>();
            CreateMap<TVA, TvaDTOOut>();
            CreateMap<TvaDTOOut, TVA>();
        }
    }
}
