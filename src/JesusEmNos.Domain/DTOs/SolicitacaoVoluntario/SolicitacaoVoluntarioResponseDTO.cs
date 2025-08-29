using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.SolicitacaoVoluntario
{
    public class SolicitacaoVoluntarioResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? UrlFoto { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorResponseDTO? Sexo { get; set; }
        public IndicadorResponseDTO? Igreja { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public IndicadorResponseDTO? TipoEndereco { get; set; }
        public MunicipioResponseDTO? Municipio { get; set; }

        public DateTime? DataResolucao { get; set; }
        public IndicadorResponseDTO? TipoSolicitacao { get; set; }
        public IndicadorResponseDTO? Situacao { get; set; }
    }
}
