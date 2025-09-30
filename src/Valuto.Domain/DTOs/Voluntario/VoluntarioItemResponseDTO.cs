using Valuto.Domain.DTOs.Endereco;
using Valuto.Domain.DTOs.Indicador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Voluntario
{
    public class VoluntarioItemResponseDTO
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorResponseDTO? Sexo { get; set; }
        public string? UrlFoto { get; set; }
        public IndicadorResponseDTO? Igreja { get; set; }
    }
}
