using Valuto.Domain.DomainTypes.Options;
using Valuto.Domain.Entities.Base;
using Valuto.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;

namespace Valuto.Infrastructure.Persistence
{
    public class ValutoContext : DbContext
    {
        private readonly DatabaseConfigurationOptions _databaseConfigurationOptions;

        public ValutoContext(DbContextOptions<ValutoContext> options, IOptions<DatabaseConfigurationOptions> databaseConfigurationOptions)
        : base(options)
        {
            _databaseConfigurationOptions = databaseConfigurationOptions.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(_databaseConfigurationOptions.DefaultSchema);

            Console.WriteLine($"Usando o schema padrão: {_databaseConfigurationOptions.DefaultSchema}");

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly, c => !c.IsAbstract);
            Expression<Func<BaseEntity, bool>> filterExpr = bm => !bm.Metadados.DataRemocao.HasValue;
            modelBuilder.Model.SetMaxIdentifierLength(60);


            foreach (var entity in modelBuilder.Model.GetEntityTypes().Where(e => e.FindOwnership() == null))
            {
                if (entity.ClrType.IsAssignableTo(typeof(BaseEntity)) && !entity.ClrType.IsAbstract)
                {
                    var parametro = Expression.Parameter(entity.ClrType);
                    var body = ReplacingExpressionVisitor.Replace(filterExpr.Parameters.First(), parametro, filterExpr.Body);
                    var lambdaExpression = Expression.Lambda(body, parametro);

                    entity.SetQueryFilter(lambdaExpression);
                }

                var entityName = entity.DisplayName().ToUpperSnakeCase();

                entity.SetTableName(entityName);
                entity.SetSchema(_databaseConfigurationOptions.DefaultSchema);

                foreach (var campo in entity.GetProperties())
                {
                    var nome = campo?.Name.ToUpperSnakeCase();

                    campo?.SetColumnName(nome?.Substring(0, Math.Min(25, nome.Length)));

                    if (campo?.ClrType == typeof(decimal) || campo?.ClrType == typeof(decimal?) || campo?.ClrType == typeof(double) || campo?.ClrType == typeof(double?))
                    {
                        if (!campo.GetScale().HasValue)
                            campo.SetScale(2);
                        if (!campo.GetPrecision().HasValue)
                            campo.SetPrecision(18);
                    }
                    if (campo.ClrType == typeof(string))
                    {
                        if (!campo.GetMaxLength().HasValue)
                            campo.SetMaxLength(250);
                    }
                }

                foreach (var key in entity.GetKeys())
                {
                    Console.WriteLine(key.GetName());
                    key.SetName(key.GetName()?.ToUpperSnakeCase());
                }

                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    var principalTable = foreignKey.PrincipalEntityType.GetTableName();
                    var dependentTable = entity.GetTableName();
                    var columnNames = string.Join("_", foreignKey.Properties.Select(p => p.Name.ToUpperSnakeCase()));

                    var constraintName = $"FK_{dependentTable}_{principalTable}_{columnNames}";

                    foreignKey.SetConstraintName(constraintName);

                    foreach (var property in foreignKey.Properties)
                    {
                        property.SetColumnName(property.Name.ToUpperSnakeCase());
                    }
                }


                foreach (var index in entity.GetIndexes())
                {
                    var tableName = entity.GetTableName();
                    var columnNames = string.Join("_", index.Properties.Select(p => p.Name.ToUpperSnakeCase()));
                    var indexName = $"IX_{tableName}_{columnNames}";

                    index.SetDatabaseName(indexName);
                }

            }
        }

        #region Override do Savechanges

        protected async virtual Task PreencherMetadados()
        {
            //var usuarioLogado = _usuarioLogadoProvider.Obter;

            long? usuarioId = null;

            //if (Database != null && !Database.IsInMemory())
            //{
            //    using (var command = Database.GetDbConnection().CreateCommand())
            //    {
            //        command.CommandText = "SELECT ID FROM USUARIO WHERE CPF = :cpf";
            //        command.Parameters.Add(new OracleParameter(":cpf", usuarioLogado.Cpf!));

            //        await Database.OpenConnectionAsync();

            //        var result = await command.ExecuteScalarAsync();
            //        if (result != DBNull.Value)
            //        {
            //            usuarioId = Convert.ToInt64(result);
            //        }
            //    }
            //}

            usuarioId = usuarioId == null ? 1 : usuarioId;

            foreach (var entityEntry in ChangeTracker.Entries())
            {
                if (entityEntry.Entity is BaseEntity)
                {
                    var baseEntity = entityEntry.Entity as BaseEntity;
                    if (entityEntry.State == EntityState.Added)
                    {
                        baseEntity!.Metadados.DataCriacao = DateTime.Now;
                        baseEntity!.Metadados. DataAtualizacao = DateTime.Now;
                        baseEntity!.Metadados.UsuarioCriacaoId = usuarioId.Value;
                        baseEntity!.Metadados.UsuarioAtualizacaoId = usuarioId.Value;
                    }
                    else if (entityEntry.State == EntityState.Modified)
                    {
                        baseEntity!.Metadados.DataAtualizacao = DateTime.Now;
                        baseEntity!.Metadados.UsuarioAtualizacaoId = usuarioId.Value;
                    }
                    else if (entityEntry.State == EntityState.Deleted)
                    {
                        entityEntry.State = EntityState.Modified;
                        baseEntity!.Metadados.DataRemocao = DateTime.Now;
                        baseEntity!.Metadados.UsuarioRemocaoId = usuarioId.Value;
                    }
                }
            }
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await PreencherMetadados();
            int i;
            try
            {
                ChangeTracker.AutoDetectChangesEnabled = false;
                i = await base.SaveChangesAsync(cancellationToken);
            }
            finally
            {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
            return i;
        }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            await PreencherMetadados();
            int i;
            try
            {
                ChangeTracker.AutoDetectChangesEnabled = false;
                i = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            }
            finally
            {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
            return i;

        }
        public override int SaveChanges()
        {
            PreencherMetadados().GetAwaiter().GetResult();
            int i;
            try
            {
                ChangeTracker.AutoDetectChangesEnabled = false;
                i = base.SaveChanges();
            }
            finally
            {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
            return i;
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            PreencherMetadados().GetAwaiter().GetResult();
            int i;
            try
            {
                ChangeTracker.AutoDetectChangesEnabled = false;
                i = base.SaveChanges(acceptAllChangesOnSuccess);
            }
            finally
            {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
            return i;
        }

        #endregion
    }
}

