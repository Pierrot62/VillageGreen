using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class EtatCommandeDTOIn
    {
        public string LibelleEtatCommande { get; set; }
    }
    class EtatCommandeDTOOut
    {
        public int IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }
    }
}
