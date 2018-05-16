using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.Data
{
    public class RBasalContext : DbContext
    {
        public RBasalContext(DbContextOptions<RBasalContext> options) : base(options)
        {

        }
    }
}
