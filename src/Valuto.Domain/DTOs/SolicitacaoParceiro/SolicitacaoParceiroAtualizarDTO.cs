using Valuto.Domain.DTOs.Indicador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.SolicitacaoParceiro
{
    public class SolicitacaoParceiroAtualizarDTO
    {
        public long Id { get; set; }
        public IndicadorDTO? Situacao { get; set; }
    }
}
