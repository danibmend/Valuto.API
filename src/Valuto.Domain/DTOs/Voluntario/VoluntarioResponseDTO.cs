using Valuto.Domain.DTOs.Contato;
using Valuto.Domain.DTOs.Endereco;
using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Voluntario
{
    public class VoluntarioResponseDTO
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorResponseDTO? Sexo { get; set; }
        public string? UrlFoto { get; set; }

        public List<VoluntarioContatoResponseDTO> Contatos { get; set; } = new();
        public EnderecoResponseDTO? Endereco { get; set; }

        public IndicadorResponseDTO? Igreja { get; set; }
    }
}
