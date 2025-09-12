using JesusEmNos.Application.Validators.Base;
using JesusEmNos.Application.Validators.Rules;
using JesusEmNos.Domain.DTOs.Rules;
using JesusEmNos.Domain.DTOs.Voluntario;
using JesusEmNos.Domain.Enums;
using JesusEmNos.Domain.Extensions;
using JesusEmNos.Domain.Interfaces.Validators.Rules;
using JesusEmNos.Domain.Interfaces.Validators.Voluntario;
using Microsoft.Extensions.DependencyInjection;

namespace JesusEmNos.Application.Validators.Voluntario
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
