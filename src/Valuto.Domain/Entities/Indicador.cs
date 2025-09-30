using Valuto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class Indicador : BaseEntity
    {
        public string? Nome { get; set; } 
        public string? Sigla { get; set; } 
        public string? Descricao { get; set; }

        public long TipoIndicadorId { get; set; }
        public TipoIndicador? TipoIndicador { get; set; }

        protected Indicador() { }

        public Indicador(string nome, string sigla, long tipoIndicadorId, string? descricao = null)
        {
            Nome = nome;
            Sigla = sigla;
            Descricao = descricao;
            TipoIndicadorId = tipoIndicadorId;
        }
    }
}
