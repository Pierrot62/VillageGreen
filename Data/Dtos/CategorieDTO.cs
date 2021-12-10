using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class CategorieDTOIn
    {
        public string LibelleCategClient { get; set; }
        public string InfoReglement { get; set; }
        public int CoefCategClient { get; set; }
    }
    class CategorieDTOOut
    {
        public int IdCategorieClient { get; set; }
        public string LibelleCategClient { get; set; }
        public string InfoReglement { get; set; }
        public int CoefCategClient { get; set; }
    }
}
