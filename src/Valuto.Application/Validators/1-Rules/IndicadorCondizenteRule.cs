using FluentValidation;
using Valuto.Application.Validators.Base;
using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.DTOs.Rules;
using Valuto.Domain.Interfaces;
using Valuto.Domain.Interfaces.Validators.Rules;
using Microsoft.Extensions.DependencyInjection;

namespace Valuto.Application.Validators.Rules
{
    public class IndicadorCondizenteRule : BaseValidator<IndicadorRulesDTO>, IIndicadorCondizenteRule
    {
        public IndicadorCondizenteRule(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            RuleFor(indicador => indicador)
                .MustAsync(VerificaIndicadorCondizente)
                .WithMessage("O indicador selecionado não é compatível com o tipo de indicador informado.");
        }

        private async Task<bool> VerificaIndicadorCondizente(IndicadorRulesDTO dto, CancellationToken cancellationToken)
        {
            var retorno = await _unitOfWork.Indicador.ObterPorIdAsync(dto.Id);

            if (retorno != null && retorno.TipoIndicadorId == dto.TipoIndicadorId)
                return true;

            return false;
        }
    }
}
