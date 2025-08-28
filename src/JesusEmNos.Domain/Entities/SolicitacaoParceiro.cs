using JesusEmNos.Domain.Entities.Base;

namespace JesusEmNos.Domain.Entities
{
    public class SolicitacaoParceiro : BaseEntity
    {
        public string? Nome { get; set; }
		public string? Cnpj { get; set; }
		public string? NomeResponsavel { get; set; }
		public string? CpfResponsavel { get; set; }
		public string? Email { get; set; } 
		public string? Telefone { get; set; } 
		public string? EmailResponsavel { get; set; }
		public string? TelefoneResponsavel { get; set; } 
		public string? UrlFoto { get; set; }
        public string? Logradouro { get; set; } 
		public string? Numero { get; set; } 
		public string? Complemento { get; set; }
        public string? Cep { get; set; } 
		public string? Bairro { get; set; } 
		public long TipoEnderecoId { get; set; }
        public Indicador? TipoEndereco { get; set; }
        public long MunicipioId { get; set; }
        public Municipio? Municipio { get; set; }

        public DateTime? DataResolucao { get; set; }
        public long TipoParceiroId { get; set; }
        public Indicador? TipoParceiro { get; set; }
        public long TipoSolicitacaoId { get; set; }
        public Indicador? TipoSolicitacao { get; set; }
        public long SituacaoId { get; set; }
        public Indicador? Situacao { get; set; }

        protected SolicitacaoParceiro() { }

        public SolicitacaoParceiro(string nome, string cnpj, string nomeResponsavel, string cpfResponsavel, string email, string telefone, string telefoneResponsavel, 
        string urlFoto, string logradouro, string numero, string bairro, string cep, long municipioId, long tipoEnderecoId, long tipoParceiroId, long tipoSolicitacaoId, 
        long situacaoId, string? emailResponsavel = null, string? complemento = null, DateTime? dataResolucao = null)
        {
            Nome = nome;
            Cnpj = cnpj;
            NomeResponsavel = nomeResponsavel;
            CpfResponsavel = cpfResponsavel;
            Email = email;
            Telefone = telefone;
            EmailResponsavel = emailResponsavel;
            TelefoneResponsavel = telefoneResponsavel;
            UrlFoto = urlFoto;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            MunicipioId = municipioId;
            TipoEnderecoId = tipoEnderecoId;
            Complemento = complemento;
            DataResolucao = dataResolucao;
            TipoParceiroId = tipoParceiroId;
            TipoSolicitacaoId = tipoSolicitacaoId;
            SituacaoId = situacaoId;
        }
    }
}
