﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class FournisseurDTOIn
    {
        public string NomFournisseur { get; set; }
    }

    class FournisseurDTOOut
    {
        public int IdFournisseur { get; set; }
        public string NomFournisseur { get; set; }
    }
}
