using Valuto.Domain.Entities;
using Valuto.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Valuto.Infrastructure.Persistence.Mappings
{
    internal class EnderecoMap : BaseEntityMap<Endereco>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Endereco> builder)
        {
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
        }
    }
}
