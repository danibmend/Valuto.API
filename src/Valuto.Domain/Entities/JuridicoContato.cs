using Valuto.Domain.Entities.Base;
using Valuto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class JuridicoContato : BaseEntity
    {
        public long JuridicoId { get; set; }
        public Juridico? Juridico { get; set; }
        public Contato? Contato { get; set; }
        protected JuridicoContato() { }

        public JuridicoContato(long JuridicoId, string valor, long tipoContatoId, long classificacaoId)
        {
            JuridicoId = JuridicoId;
            Contato = new Contato(valor, tipoContatoId, classificacaoId);
        }
    }
}