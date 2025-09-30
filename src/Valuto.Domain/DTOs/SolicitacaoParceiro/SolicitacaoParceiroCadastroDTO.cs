using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.SolicitacaoParceiro
{
    public class SolicitacaoParceiroCadastroDTO
    {
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
        public IndicadorDTO? TipoEndereco { get; set; }
        public MunicipioDTO? Municipio { get; set; }
        public IndicadorDTO? TipoParceiro { get; set; }
        public IndicadorDTO? TipoSolicitacao { get; set; }
    }
}
