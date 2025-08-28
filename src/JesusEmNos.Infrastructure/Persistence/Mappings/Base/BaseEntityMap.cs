using JesusEmNos.Domain.Entities.Base;
using JesusEmNos.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JesusEmNos.Infrastructure.Persistence.Mappings.Base
{
    internal abstract class BaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName(nameof(BaseEntity.Id).ToUpperSnakeCase());

            builder.OwnsOne(e => e.Metadados, owned =>
            {
                owned.WithOwner();

                owned.Property(m => m.DataCriacao)
                    .IsRequired()
                    .HasColumnName(nameof(Metadados.DataCriacao).ToUpperSnakeCase());

                owned.Property(m => m.DataAtualizacao)
                    .IsRequired()
                    .HasColumnName(nameof(Metadados.DataAtualizacao).ToUpperSnakeCase());

                owned.Property(m => m.UsuarioCriacaoId)
                    .IsRequired()
                    .HasColumnName(nameof(Metadados.UsuarioCriacaoId).ToUpperSnakeCase());

                owned.Property(m => m.UsuarioAtualizacaoId)
                    .IsRequired()
                    .HasColumnName(nameof(Metadados.UsuarioAtualizacaoId).ToUpperSnakeCase());

                owned.Property(m => m.DataRemocao)
                    .HasColumnName(nameof(Metadados.DataRemocao).ToUpperSnakeCase());

                owned.Property(m => m.UsuarioRemocaoId)
                    .HasColumnName(nameof(Metadados.UsuarioRemocaoId).ToUpperSnakeCase());
            });



            builder.Navigation(e => e.Metadados).IsRequired();

            ConfigureMapping(builder);
            Seed(builder);
        }

        protected abstract void ConfigureMapping(EntityTypeBuilder<TEntity> builder);

        protected virtual void Seed(EntityTypeBuilder<TEntity> builder)
        {
        }
    }
}
