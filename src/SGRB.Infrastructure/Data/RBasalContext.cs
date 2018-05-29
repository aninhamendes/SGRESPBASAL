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


            #region Configurações de Pesquisador

            modelBuilder.Entity<Pesquisador>().Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Pesquisador>().Property(c => c.InstituicaoDeEnsino)
               .HasColumnType("varchar(100)")
               .IsRequired();
            #endregion

            #region Configurações de Caracterização da Area

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.TipoArea)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.Cidade)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.TipoClima)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.TipoSolo)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.DescricaoAmbiente)
               .HasColumnType("varchar(10000)")
               .IsRequired();

            modelBuilder.Entity<CaracterizacaoArea>().Property(c => c.TamanhoPropriedade)
               .HasColumnType("varchar(100)")
               .IsRequired();

            #endregion

            #region Configurações de Coleta de Amostra

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.DataColeta)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.Profundidade)
               .HasColumnType("varchar(50)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.Armazenamento)
               .HasColumnType("varchar(10000)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.TempodeRepouso)
               .HasColumnType("varchar(30)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.PesoAmostra)
               .HasColumnType("varchar(40)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.TipodeTratamento)
               .HasColumnType("varchar(10000)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.TipodeEcossistema)
               .HasColumnType("varchar(200)")
               .IsRequired();

            modelBuilder.Entity<ColetaAmostra>().Property(c => c.Sazonalidade)
               .HasColumnType("varchar(100)")
               .IsRequired();

            #endregion

            #region Configurações de Processamento de Amostra

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.Peneira)
               .HasColumnType("varchar(10)")
               .IsRequired();

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.Solucoes)
               .HasColumnType("varchar(3000)")
               .IsRequired();

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.TipodeArmazenamento)
               .HasColumnType("varchar(5000)")
               .IsRequired();

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.Refrigeracao)
               .HasColumnType("varchar(30)")
               .IsRequired();

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.PeriodoIncubacao)
               .HasColumnType("varchar(50)")
               .IsRequired();

            modelBuilder.Entity<ProcessamentoAmostra>().Property(c => c.DescricaoProcedimento)
               .HasColumnType("varchar(8000)")
               .IsRequired();
           
            #endregion
        }
    }
}
