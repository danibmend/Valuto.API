using JesusEmNos.Domain.Entities.Base;
using JesusEmNos.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
{
    public class ParceiroContato : BaseEntity
    {
        public long ParceiroId { get; set; }
        public Parceiro? Parceiro { get; set; }
        public Contato? Contato { get; set; }
        protected ParceiroContato() { }

        public ParceiroContato(long parceiroId, string valor, long tipoContatoId, long classificacaoId)
        {
            ParceiroId = parceiroId;
            Contato = new Contato(valor, tipoContatoId, classificacaoId);
        }
    }
}