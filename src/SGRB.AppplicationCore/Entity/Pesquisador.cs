﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.AppplicationCore.Entity
{
    public class Pesquisador
    {
        public Pesquisador()
        {
               
        }

        public int PesquisadorId { get; set; }
        public string Nome { get; set; }
        public string InstituicaoDeEnsino { get; set; }

    }
}
