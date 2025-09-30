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
    internal class SolicitacaoParceiroMap : BaseEntityMap<SolicitacaoParceiro>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<SolicitacaoParceiro> builder)
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

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Telefone)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(e => e.EmailResponsavel)
                .HasMaxLength(100);


            builder.Property(e => e.TelefoneResponsavel)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.Complemento)
                .HasMaxLength(100);

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8);

            builder.HasOne(e => e.TipoEndereco)
                .WithMany()
                .HasForeignKey(e => e.TipoEnderecoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.Municipio)
                .WithMany()
                .HasForeignKey(e => e.MunicipioId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.TipoParceiro)
                .WithMany()
                .HasForeignKey(e => e.TipoParceiroId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.TipoSolicitacao)
                .WithMany()
                .HasForeignKey(e => e.TipoSolicitacaoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.Situacao)
                .WithMany()
                .HasForeignKey(e => e.SituacaoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
