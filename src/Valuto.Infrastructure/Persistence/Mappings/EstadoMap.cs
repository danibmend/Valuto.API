using Valuto.Domain.Entities;
using Valuto.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Infrastructure.Persistence.Mappings
{
    internal class EstadoMap : BaseEntityMap<Estado>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Estado> builder)
        {
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(e => e.Sigla)
                .IsRequired()
                .HasMaxLength(2);

            builder.HasIndex(e => e.Nome).IsUnique();

            builder.HasIndex(e => e.Sigla).IsUnique();
        }
    }
}
