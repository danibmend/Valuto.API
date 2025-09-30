using Valuto.Domain.DTOs.Contato;
using Valuto.Domain.DTOs.Endereco;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Juridico
{
    public class JuridicoCadastroDTO
    {
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
        public List<ContatoDTO> Contatos { get; set; } = new();
        public EnderecoCadastroDTO? Endereco { get; set; }
        public long TipoJuridicoId { get; set; }
    }
}
