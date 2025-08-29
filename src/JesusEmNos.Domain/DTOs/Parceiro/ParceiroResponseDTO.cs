using JesusEmNos.Domain.DTOs.Contato;
using JesusEmNos.Domain.DTOs.Endereco;
using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Parceiro
{
    public class ParceiroResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public List<ParceiroContatoResponseDTO> Contatos { get; set; } = new();
        public EnderecoResponseDTO? Endereco { get; set; }
        public IndicadorResponseDTO? TipoParceiro { get; set; }
    }
}
