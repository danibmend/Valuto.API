using JesusEmNos.Domain.Entities;
using JesusEmNos.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JesusEmNos.Infrastructure.Persistence.Mappings
{
    internal class IndicadorMap : BaseEntityMap<Indicador>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Indicador> builder)
        {
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Sigla)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(e => e.Descricao)
                .HasMaxLength(500);

            builder.HasOne(e => e.TipoIndicador)
                .WithMany()
                .HasForeignKey(e => e.TipoIndicadorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasIndex(e => e.Nome).IsUnique();

            builder.HasIndex(e => e.Sigla).IsUnique();
        }
    }
}
