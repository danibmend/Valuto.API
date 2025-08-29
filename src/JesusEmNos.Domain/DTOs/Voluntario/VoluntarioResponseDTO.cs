using JesusEmNos.Domain.DTOs.Contato;
using JesusEmNos.Domain.DTOs.Endereco;
using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Voluntario
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
