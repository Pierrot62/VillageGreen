using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class TvaDTOIn
    {
        public int TauxTva { get; set; }
    }
    class TvaDTOOut
    {
        public int IdTva { get; set; }
        public int TauxTva { get; set; }
    }
}
