using JesusEmNos.Domain.DTOs.Indicador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.SolicitacaoVoluntario
{
    public class SolicitacaoVoluntarioAtualizarDTO
    {
        public long Id { get; set; }
        public IndicadorDTO? Situacao { get; set; }
    }
}
