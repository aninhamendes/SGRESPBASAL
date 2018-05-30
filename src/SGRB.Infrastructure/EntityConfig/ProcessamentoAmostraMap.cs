using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGRB.AppplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.EntityConfig
{
    class ProcessamentoAmostraMap : IEntityTypeConfiguration<ProcessamentoAmostra>
    {
        public void Configure(EntityTypeBuilder<ProcessamentoAmostra> builder)
        {
            builder.Property(c => c.Peneira)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.Property(c => c.Solucoes)
               .HasColumnType("varchar(3000)")
               .IsRequired();

            builder.Property(c => c.TipodeArmazenamento)
               .HasColumnType("varchar(5000)")
               .IsRequired();

            builder.Property(c => c.Refrigeracao)
               .HasColumnType("varchar(30)")
               .IsRequired();

            builder.Property(c => c.PeriodoIncubacao)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(c => c.DescricaoProcedimento)
               .HasColumnType("varchar(8000)")
               .IsRequired();

        }
    }
}
