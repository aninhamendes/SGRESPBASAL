using Microsoft.EntityFrameworkCore;
using SGRB.AppplicationCore.Entity;
using SGRB.Infrastructure.EntityConfig;
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

        public DbSet<ProcessamentoAmostra> ProcessamentoAmostras { get; set; }

        public DbSet<MateriaisEquipamentos> Materiais { get; set; }

        public DbSet<ColetaAmostra> ColetaAmostras { get; set; }

        public DbSet<CaracterizacaoArea> CaracterizacaoAreas { get; set; }

        public DbSet<CalculoBasal> CalculoBasals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pesquisador>().ToTable("Pesquisador");
            modelBuilder.Entity<ProcessamentoAmostra>().ToTable("ProcessamentodeAmostra");
            modelBuilder.Entity<MateriaisEquipamentos>().ToTable("MateriaiseEquipamentos");
            modelBuilder.Entity<ColetaAmostra>().ToTable("ColetadeAmostra");
            modelBuilder.Entity<CaracterizacaoArea>().ToTable("CaracterizacaodaArea");
            modelBuilder.Entity<CalculoBasal>().ToTable("CalculoBasal");
            modelBuilder.ApplyConfiguration(new PesquisadorMap());
            modelBuilder.ApplyConfiguration(new CaracterizacaoAreaMap());
            modelBuilder.ApplyConfiguration(new ColetaAmostraMap());
            modelBuilder.ApplyConfiguration(new ProcessamentoAmostraMap());




        }
    }
}
