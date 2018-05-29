using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;  

namespace SGRB.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RBasalContext context)
        {
            if (context.Pesquisadores.Any())
            {
                return;
            }
        }
    }
}
