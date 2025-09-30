using Valuto.Application.Validators.Base;
using Valuto.Application.Validators.Rules;
using Valuto.Domain.DTOs.Rules;
using Valuto.Domain.DTOs.Voluntario;
using Valuto.Domain.Enums;
using Valuto.Domain.Extensions;
using Valuto.Domain.Interfaces.Validators.Rules;
using Valuto.Domain.Interfaces.Validators.Voluntario;
using Microsoft.Extensions.DependencyInjection;

namespace Valuto.Application.Validators.Voluntario
{
    public class VoluntarioCadastroValidator : BaseValidator<VoluntarioCadastroDTO>, IVoluntarioCadastroValidator
    {
        public readonly IServiceProvider _serviceProvider;

        public VoluntarioCadastroValidator(IServiceProvider serviceProvider) : base(serviceProvider) 
        {
            _serviceProvider = serviceProvider;

            RuleFor(voluntario => new IndicadorRulesDTO
            {
                Id = voluntario.Sexo!.Id,
                TipoIndicadorId = (long)TipoIndicador.Sexo
            })
            .SetValidator(_serviceProvider.GetRequiredService<IIndicadorCondizenteRule>());
        }
    }
}
