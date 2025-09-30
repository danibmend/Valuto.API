using Valuto.Domain.DTOs.Contato;
using Valuto.Domain.DTOs.Endereco;

namespace Valuto.Domain.DTOs.Juridico
{
    public class JuridicoAtualizarDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public List<JuridicoContatoAtualizarDTO> Contatos { get; set; } = new();
        public EnderecoAtualizarDTO? Endereco { get; set; }
        public long TipoJuridicoId { get; set; }
    }
}
