using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGRB.AppplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.EntityConfig
{
    public class CaracterizacaoAreaMap : IEntityTypeConfiguration<CaracterizacaoArea>
    {
        public void Configure(EntityTypeBuilder<CaracterizacaoArea> builder)
        {
            builder.Property(c => c.TipoArea)
              .HasColumnType("varchar(100)")
              .IsRequired();

            builder.Property(c => c.Cidade)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.TipoClima)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.TipoSolo)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.DescricaoAmbiente)
               .HasColumnType("varchar(7500)")
               .IsRequired();

            builder.Property(c => c.TamanhoPropriedade)
               .HasColumnType("varchar(100)")
               .IsRequired();
        }
    }
}
