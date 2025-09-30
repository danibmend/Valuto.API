using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.SolicitacaoParceiro
{
    public class SolicitacaoParceiroItemResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public DateTime? DataResolucao { get; set; }
        public IndicadorResponseDTO? TipoParceiro { get; set; }
        public IndicadorResponseDTO? TipoSolicitacao { get; set; }
        public IndicadorResponseDTO? Situacao { get; set; }
    }
}
