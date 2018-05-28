using Microsoft.EntityFrameworkCore;
using SGRB.AppplicationCore.Entity;
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

        public DbSet<Pesquisador> Pesquisadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pesquisador>().ToTable("Pesquisador");
        }
    }
}
