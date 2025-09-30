using Valuto.Domain.Entities;
using Valuto.Domain.Entities.Base;
using Valuto.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Infrastructure.Persistence.Mappings
{
    internal class ParceiroContatoMap : BaseEntityMap<ParceiroContato>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<ParceiroContato> builder)
        {

            builder.OwnsOne(e => e.Contato, owned =>
            {
                owned.Property(m => m.Valor)
                    .IsRequired()
                    .HasMaxLength(100);
                owned.HasOne(m => m.TipoContato)
                    .WithMany()
                    .HasForeignKey(m => m.TipoContatoId)
                    .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict)
                    .IsRequired();
                owned.HasOne(m => m.Classificacao)
                    .WithMany()
                    .HasForeignKey(m => m.ClassificacaoId)
                    .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict)
                    .IsRequired();
            });

            builder.Navigation(e => e.Contato).IsRequired();

            builder.HasOne(e => e.Parceiro)
                .WithMany(p => p.Contatos)
                .HasForeignKey(e => e.ParceiroId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade)
                .IsRequired();
        }

    }
}
