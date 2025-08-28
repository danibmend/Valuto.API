using JesusEmNos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
{
    public class Parceiro : BaseEntity
    {
        public string? Nome { get; set; } 
        public string? Cnpj { get; set; } 
        public string? NomeResponsavel { get; set; } 
        public string? CpfResponsavel { get; set; } 
        public string? UrlFoto { get; set; }
        public List<ParceiroContato> Contatos { get; set; } = new();
        public long EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public long TipoParceiroId { get; set; }
        public Indicador? TipoParceiro { get; set; }

        protected Parceiro() { }

        public Parceiro(string nome, string cnpj, string nomeResponsavel, string cpfResponsavel, long enderecoId, long tipoParceiroId, string? urlFoto = null)
        {
            Nome = nome;
            Cnpj = cnpj;
            NomeResponsavel = nomeResponsavel;
            CpfResponsavel = cpfResponsavel;
            UrlFoto = urlFoto;
            EnderecoId = enderecoId;
            TipoParceiroId = tipoParceiroId;
        }
    }
}
