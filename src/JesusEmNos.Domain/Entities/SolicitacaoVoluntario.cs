using JesusEmNos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
{
    public class SolicitacaoVoluntario : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? UrlFoto { get; set; }
        public DateTime DataNascimento { get; set; }
        public long SexoId { get; set; }
        public Indicador? Sexo { get; set; }
        public long IgrejaId { get; set; }
        public Indicador? Igreja { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public long TipoEnderecoId { get; set; }
        public Indicador? TipoEndereco { get; set; }
        public long MunicipioId { get; set; }
        public Municipio? Municipio { get; set; }

        public DateTime? DataResolucao { get; set; }
        public long TipoSolicitacaoId { get; set; }
        public Indicador? TipoSolicitacao { get; set; }
        public long SituacaoId { get; set; }
        public Indicador? Situacao { get; set; }

        protected SolicitacaoVoluntario() { }

        public SolicitacaoVoluntario(string nome, string cpf, string email, string telefone, string urlFoto, DateTime dataNascimento, long sexoId, 
        long igrejaId, string logradouro, string numero, string bairro, string cep, long municipioId, long tipoEnderecoId, long tipoSolicitacaoId,
        long situacaoId, string? complemento = null, DateTime? dataResolucao = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            UrlFoto = urlFoto;
            DataNascimento = dataNascimento;
            IgrejaId = igrejaId;
            SexoId = sexoId;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            MunicipioId = municipioId;
            TipoEnderecoId = tipoEnderecoId;
            Complemento = complemento;
            DataResolucao = dataResolucao;
            TipoSolicitacaoId = tipoSolicitacaoId;
            SituacaoId = situacaoId;
        }
    }
}