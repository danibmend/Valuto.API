using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.ValueObjects
{
    public class Contato
    {
        public string? Valor { get; set; }

        public long TipoContatoId { get; set; }
        public Indicador? TipoContato { get; set; }
        public long ClassificacaoId { get; set; }
        public Indicador? Classificacao { get; set; }

        protected Contato() { }

        public Contato(string valor, long tipoContatoId, long classificacaoId)
        {
            Valor = valor;
            TipoContatoId = tipoContatoId;
            ClassificacaoId = classificacaoId;
        }
    }
}
