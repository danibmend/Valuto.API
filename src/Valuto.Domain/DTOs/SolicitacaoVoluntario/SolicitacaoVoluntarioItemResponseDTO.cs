using Valuto.Domain.DTOs.Indicador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.SolicitacaoVoluntario
{
    public class SolicitacaoVoluntarioItemResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? UrlFoto { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorResponseDTO? Sexo { get; set; }
        public IndicadorResponseDTO? Igreja { get; set; }
        public DateTime? DataResolucao { get; set; }
        public IndicadorResponseDTO? TipoSolicitacao { get; set; }
        public IndicadorResponseDTO? Situacao { get; set; }
    }
}
