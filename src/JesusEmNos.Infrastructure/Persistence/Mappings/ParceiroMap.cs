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
    internal class ParceiroMap : BaseEntityMap<Parceiro>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Parceiro> builder)
        {
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Cnpj)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(e => e.NomeResponsavel)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.CpfResponsavel)
                .IsRequired()
                .HasMaxLength(11);

            builder.HasOne(e => e.Endereco)
                .WithOne()
                .HasForeignKey<Parceiro>(e => e.EnderecoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.TipoParceiro)
                .WithMany()
                .HasForeignKey(e => e.TipoParceiroId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasIndex(e => e.EnderecoId).IsUnique();
            builder.HasIndex(e => e.Cnpj).IsUnique();
        }
    }
}
