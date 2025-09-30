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
    public class VoluntarioContato : BaseEntity
    {
        public long VoluntarioId { get; set; }
        public Voluntario? Voluntario { get; set; }
        public Contato? Contato { get; set; }

        protected VoluntarioContato() { }

        public VoluntarioContato(long voluntarioId, long contatoId, string valor, long tipoContatoId, long classificacaoId)
        {
            VoluntarioId = voluntarioId;
            Contato = new Contato(valor, tipoContatoId, classificacaoId);
        }
    }
}
