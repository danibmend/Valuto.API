using Valuto.Domain.Entities.Base;

namespace Valuto.Domain.Entities
{
    public class TipoIndicador : BaseEntity
    {
        public string? Nome { get; set; } 
		public string? Sigla { get; set; } 
		public string? Descricao { get; set; }

        protected TipoIndicador() { }

        public TipoIndicador(string nome, string sigla, string? descricao = null)
        {
            Nome = nome;
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}
