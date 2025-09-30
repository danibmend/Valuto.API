using Valuto.Domain.Entities;

namespace Valuto.Domain.ValueObjects
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
