﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    class PaysDTOIn
    {
        public string NomPays { get; set; }
    }
    class PaysDTOOut
    {
        public int IdPays { get; set; }
        public string NomPays { get; set; }
    }
}
