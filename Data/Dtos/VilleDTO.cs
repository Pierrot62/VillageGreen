using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class VilleDTOIn
    {
        public string LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }
    }

    class VilleDTOOut
    {
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }
        public string NomPays { get; set; }
    }
}
