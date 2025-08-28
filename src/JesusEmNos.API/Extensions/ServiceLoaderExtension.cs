using JesusEmNos.Domain.DomainTypes.Options;

namespace JesusEmNos.API.Extensions
{
    public static class ServiceLoaderExtension
    {
        public static void LoadConfigOptions(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.Configure<DatabaseConfigurationOptions>(configuration.GetSection(nameof(DatabaseConfigurationOptions)));
        }
    }
}
