using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.DTOs.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Endereco
{
    public class EnderecoCadastroDTO
    {
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public IndicadorDTO? TipoEndereco { get; set; }
        public MunicipioDTO? Municipio { get; set; }
    }
}
