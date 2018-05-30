using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGRB.AppplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.EntityConfig
{
    public class PesquisadorMap : IEntityTypeConfiguration<Pesquisador>
    {
        public void Configure(EntityTypeBuilder<Pesquisador> builder)
        {
            builder.Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(c => c.InstituicaoDeEnsino)
               .HasColumnType("varchar(100)")
               .IsRequired();
        }
    }
}
