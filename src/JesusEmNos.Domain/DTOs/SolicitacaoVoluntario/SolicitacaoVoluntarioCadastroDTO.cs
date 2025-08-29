using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.SolicitacaoVoluntario
{
    public class SolicitacaoVoluntarioCadastroDTO
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? UrlFoto { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorDTO? Sexo { get; set; }
        public IndicadorDTO? Igreja { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public IndicadorDTO? TipoEndereco { get; set; }
        public MunicipioDTO? Municipio { get; set; }
        public IndicadorDTO? TipoSolicitacao { get; set; }
        public IndicadorDTO? Situacao { get; set; }
    }
}
