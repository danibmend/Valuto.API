using FluentValidation;
using Valuto.API.Mapping.Base;
using Valuto.Application.Interfaces.Services;
using Valuto.Application.Mappings.Base;
using Valuto.Application.Services;
using Valuto.Application.Validators.Rules;
using Valuto.Application.Validators.Pessoa;
using Valuto.Domain.DomainTypes.Options;
using Valuto.Domain.DTOs.Pessoa;
using Valuto.Domain.Interfaces.Repositories;
using Valuto.Domain.Interfaces.Validators.Rules;
using Valuto.Infrastructure.Repositories;

namespace Valuto.API.Extensions
{
    public static class ServiceLoaderExtension
    {
        public static void LoadConfigOptions(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAutoMapper(cfg => { }, typeof(MappingDTOProfiles).Assembly, typeof(MappingRequestProfile).Assembly);
            services.Configure<DatabaseConfigurationOptions>(configuration.GetSection(nameof(DatabaseConfigurationOptions)));
        }

        public static void LoadServices(this IServiceCollection services)
        {
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<ILocalidadeService, LocalidadeService>();
            services.AddScoped<IIndicadorService, IndicadorService>();
            services.AddScoped<IJuridicoContatoService, JuridicoContatoService>();
            services.AddScoped<IJuridicoService, JuridicoService>();
            services.AddScoped<ISolicitacaoPessoaService, SolicitacaoPessoaService>();
            services.AddScoped<ITipoIndicadorService, TipoIndicadorService>();
            services.AddScoped<IPessoaContatoService, PessoaContatoService>();
            services.AddScoped<IPessoaService, PessoaService>();
        }

        public static void LoadApiServices(this IServiceCollection services)
        {
        }

        public static void LoadFactories(this IServiceCollection services)
        {
        }

        public static void LoadRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IIndicadorRepository, IndicadorRepository>();
            services.AddScoped<IMunicipioRepository, MunicipioRepository>();
            services.AddScoped<IJuridicoContatoRepository, JuridicoContatoRepository>();
            services.AddScoped<IJuridicoRepository, JuridicoRepository>();
            services.AddScoped<ISolicitacaoPessoaRepository, SolicitacaoPessoaRepository>();
            services.AddScoped<ITipoIndicadorRepository, TipoIndicadorRepository>();
            services.AddScoped<IPessoaContatoRepository, PessoaContatoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
        }

        public static void LoadValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<PessoaCadastroDTO>, PessoaCadastroValidator>();
        }

        public static void LoadValidatorsRules(this IServiceCollection services)
        {
            services.AddScoped<IIndicadorCondizenteRule, IndicadorCondizenteRule>();
        }

    }
}
