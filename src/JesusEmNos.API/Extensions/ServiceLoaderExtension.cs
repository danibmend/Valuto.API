using JesusEmNos.API.Mapping.Base;
using JesusEmNos.Application.Mappings.Base;
using JesusEmNos.Domain.DomainTypes.Options;
using JesusEmNos.Domain.Interfaces.Repositories;
using JesusEmNos.Infrastructure.Repositories;

namespace JesusEmNos.API.Extensions
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
            services.AddScoped<IParceiroContatoRepository, ParceiroContatoRepository>();
            services.AddScoped<IParceiroRepository, ParceiroRepository>();
            services.AddScoped<ISolicitacaoParceiroRepository, SolicitacaoParceiroRepository>();
            services.AddScoped<ISolicitacaoVoluntarioRepository, SolicitacaoVoluntarioRepository>();
            services.AddScoped<ITipoIndicadorRepository, TipoIndicadorRepository>();
            services.AddScoped<IVoluntarioContatoRepository, VoluntarioContatoRepository>();
            services.AddScoped<IVoluntarioRepository, VoluntarioRepository>();
        }

        public static void LoadValidators(this IServiceCollection services)
        {
        }

    }
}
