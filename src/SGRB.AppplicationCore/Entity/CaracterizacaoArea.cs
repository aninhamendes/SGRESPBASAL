﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.AppplicationCore.Entity
{
   public class CaracterizacaoArea
    {
        public int CaracterizacaoAreaId { get; set; }

        public string TipoArea { get; set; }

        public string Cidade { get; set; }

        public string TipoClima { get; set; }

        public string TipoSolo { get; set; }

        public string DescricaoAmbiente { get; set; }

        public double TamanhoPropriedade { get; set; }
    }
}
