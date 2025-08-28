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
    internal class MunicipioMap : BaseEntityMap<Municipio>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Municipio> builder)
        {
            builder.Property(e => e.CodIbge7)
                .IsRequired()
                .HasMaxLength(7);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(e => e.Estado)
                .WithMany(e => e.Municipios)
                .HasForeignKey(e => e.EstadoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasIndex(e => e.CodIbge7).IsUnique();
        }
    }
}
