using JesusEmNos.Domain.Entities;
using JesusEmNos.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Infrastructure.Persistence.Mappings
{
    internal class TipoIndicadorMap : BaseEntityMap<TipoIndicador>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<TipoIndicador> builder)
        {
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(c => c.Descricao)
                .HasMaxLength(500);

            builder.HasIndex(e => e.Nome).IsUnique();

            builder.HasIndex(e => e.Sigla).IsUnique();
        }
    }
}
