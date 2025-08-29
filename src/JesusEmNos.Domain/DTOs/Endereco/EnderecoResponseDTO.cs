using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Endereco
{
    public class EnderecoResponseDTO
    {
        public long Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public IndicadorResponseDTO? TipoEndereco { get; set; }
        public MunicipioResponseDTO? Municipio { get; set; }
    }
}
