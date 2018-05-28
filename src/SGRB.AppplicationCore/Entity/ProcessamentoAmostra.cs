﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.AppplicationCore.Entity
{
    public class ProcessamentoAmostra
    {
        public int Peneira { get; set; }

        public string Solucoes { get; set; }

        public string TipodeArmazenamento { get; set; }

        public double Refrigeracao { get; set; }

        public DateTime PeriodoIncubacao { get; set; }

        public string DescricaoProcedimento { get; set; }

    }
}
