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
    public class VoluntarioCadastroDTO
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public IndicadorDTO? Sexo { get; set; }
        public string? UrlFoto { get; set; }

        public List<ContatoDTO> Contatos { get; set; } = new();
        public EnderecoCadastroDTO? Endereco { get; set; }

        public IndicadorDTO? Igreja { get; set; }
    }
}
