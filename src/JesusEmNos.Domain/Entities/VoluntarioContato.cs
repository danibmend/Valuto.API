using JesusEmNos.Domain.Entities.Base;
using JesusEmNos.Domain.Enums;
using JesusEmNos.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
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
