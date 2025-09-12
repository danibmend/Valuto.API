using FluentValidation;
using JesusEmNos.Application.Validators.Base;
using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Rules;
using JesusEmNos.Domain.Interfaces;
using JesusEmNos.Domain.Interfaces.Validators.Rules;
using Microsoft.Extensions.DependencyInjection;

namespace JesusEmNos.Application.Validators.Rules
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
