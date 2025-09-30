using Valuto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class Juridico : BaseEntity
    {
        public string? Nome { get; set; } 
        public string? Cnpj { get; set; } 
        public string? NomeResponsavel { get; set; } 
        public string? CpfResponsavel { get; set; } 
        public string? UrlFoto { get; set; }
        public List<JuridicoContato> Contatos { get; set; } = new();
        public long EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public long TipoJuridicoId { get; set; }
        public Indicador? TipoJuridico { get; set; }

        protected Juridico() { }

        public Juridico(string nome, string cnpj, string nomeResponsavel, string cpfResponsavel, long enderecoId, long tipoJuridicoId, string? urlFoto = null)
        {
            Nome = nome;
            Cnpj = cnpj;
            NomeResponsavel = nomeResponsavel;
            CpfResponsavel = cpfResponsavel;
            UrlFoto = urlFoto;
            EnderecoId = enderecoId;
            TipoJuridicoId = tipoJuridicoId;
        }
    }
}
