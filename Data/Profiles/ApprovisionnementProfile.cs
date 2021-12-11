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
    class ApprovisionnementProfile : Profile
    {
        public ApprovisionnementProfile()
        {
            CreateMap<ApprovisionnementDTOIn, Approvisionnement>();
            CreateMap<Approvisionnement, ApprovisionnementDTOIn>();
            CreateMap<Approvisionnement, ApprovisionnementDTOOut>()
                .ForMember(d => d.NomFournisseur, o => o.MapFrom(s => s.Fournisseur.NomFournisseur));
            CreateMap<ApprovisionnementDTOOut, Approvisionnement>();
                }
    }
}
