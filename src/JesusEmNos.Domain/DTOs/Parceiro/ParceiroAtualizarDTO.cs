using JesusEmNos.Domain.DTOs.Contato;
using JesusEmNos.Domain.DTOs.Endereco;

namespace JesusEmNos.Domain.DTOs.Parceiro
{
    public class ParceiroAtualizarDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public List<ParceiroContatoAtualizarDTO> Contatos { get; set; } = new();
        public EnderecoAtualizarDTO? Endereco { get; set; }
        public long TipoParceiroId { get; set; }
    }
}
