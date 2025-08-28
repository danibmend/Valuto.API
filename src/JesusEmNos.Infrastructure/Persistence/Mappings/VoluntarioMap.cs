using JesusEmNos.Domain.Entities;
using JesusEmNos.Infrastructure.Persistence.Mappings.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JesusEmNos.Infrastructure.Persistence.Mappings
{
    internal class VoluntarioMap : BaseEntityMap<Voluntario>
    {
        protected override void ConfigureMapping(EntityTypeBuilder<Voluntario> builder)
        {
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(e => e.DataNascimento)
                .IsRequired();

            builder.HasOne(e => e.Sexo)
                .WithMany()
                .HasForeignKey(e => e.SexoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.Igreja)
                .WithMany()
                .HasForeignKey(e => e.IgrejaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(e => e.Endereco)
                .WithOne()
                .HasForeignKey<Voluntario>(e => e.EnderecoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasIndex(e => e.EnderecoId).IsUnique();
            builder.HasIndex(e => e.Cpf).IsUnique();

        }
    }
}
