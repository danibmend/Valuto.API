using Valuto.Application.Validators.Base;
using Valuto.Application.Validators.Rules;
using Valuto.Domain.DTOs.Rules;
using Valuto.Domain.DTOs.Pessoa;
using Valuto.Domain.Enums;
using Valuto.Domain.Extensions;
using Valuto.Domain.Interfaces.Validators.Rules;
using Valuto.Domain.Interfaces.Validators.Pessoa;
using Microsoft.Extensions.DependencyInjection;

namespace Valuto.Application.Validators.Pessoa
{
    public class PessoaCadastroValidator : BaseValidator<PessoaCadastroDTO>, IPessoaCadastroValidator
    {
        public readonly IServiceProvider _serviceProvider;

        public PessoaCadastroValidator(IServiceProvider serviceProvider) : base(serviceProvider) 
        {
            _serviceProvider = serviceProvider;

            RuleFor(Pessoa => new IndicadorRulesDTO
            {
                Id = Pessoa.Sexo!.Id,
                TipoIndicadorId = (long)TipoIndicador.Sexo
            })
            .SetValidator(_serviceProvider.GetRequiredService<IIndicadorCondizenteRule>());
        }
    }
}
