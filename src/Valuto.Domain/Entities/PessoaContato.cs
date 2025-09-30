using Valuto.Domain.Entities.Base;
using Valuto.Domain.Enums;
using Valuto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class PessoaContato : BaseEntity
    {
        public long PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
        public Contato? Contato { get; set; }

        protected PessoaContato() { }

        public PessoaContato(long PessoaId, long contatoId, string valor, long tipoContatoId, long classificacaoId)
        {
            PessoaId = PessoaId;
            Contato = new Contato(valor, tipoContatoId, classificacaoId);
        }
    }
}
