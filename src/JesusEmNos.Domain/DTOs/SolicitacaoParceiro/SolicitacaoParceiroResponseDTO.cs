using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.SolicitacaoParceiro
{
    public class SolicitacaoParceiroResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? EmailResponsavel { get; set; }
        public string? TelefoneResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public IndicadorResponseDTO? TipoEndereco { get; set; }
        public MunicipioResponseDTO? Municipio { get; set; }

        public DateTime? DataResolucao { get; set; }
        public IndicadorResponseDTO? TipoParceiro { get; set; }
        public IndicadorResponseDTO? TipoSolicitacao { get; set; }
        public IndicadorResponseDTO? Situacao { get; set; }
    }
}
