using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class ReglementDTOIn
    {
        public string TypePaiement { get; set; }
    }

    class ReglementDTOOut
    {
        public int IdReglement { get; set; }
        public string TypePaiement { get; set; }
    }
}
