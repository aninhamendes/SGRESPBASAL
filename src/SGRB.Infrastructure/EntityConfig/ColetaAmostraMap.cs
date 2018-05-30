using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGRB.AppplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.EntityConfig
{
    public class ColetaAmostraMap : IEntityTypeConfiguration<ColetaAmostra>
    {
        public void Configure(EntityTypeBuilder<ColetaAmostra> builder)
        {
            builder.Property(c => c.DataColeta)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.Profundidade)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(c => c.Armazenamento)
               .HasColumnType("varchar(7890)")
               .IsRequired();

            builder.Property(c => c.TempodeRepouso)
               .HasColumnType("varchar(30)")
               .IsRequired();

            builder.Property(c => c.PesoAmostra)
               .HasColumnType("varchar(40)")
               .IsRequired();

            builder.Property(c => c.TipodeTratamento)
               .HasColumnType("varchar(7890)")
               .IsRequired();

            builder.Property(c => c.TipodeEcossistema)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(c => c.Sazonalidade)
               .HasColumnType("varchar(100)")
               .IsRequired();
        }
    }
    }

