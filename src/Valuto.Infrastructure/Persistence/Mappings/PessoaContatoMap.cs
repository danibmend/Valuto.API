using Valuto.Domain.Entities;
using Valuto.Infrastructure.Persistence.Mappings.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Infrastructure.Persistence.Mappings
{
    internal class PessoaContatoMap : BaseEntityMap<PessoaContato>
    {
        protected override void ConfigureMapping(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PessoaContato> builder)
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

            builder.HasOne(e => e.Pessoa)
                .WithMany(v => v.Contatos)
                .HasForeignKey(e => e.PessoaId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
