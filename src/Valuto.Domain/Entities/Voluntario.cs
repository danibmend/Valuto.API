using Valuto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class Voluntario : BaseEntity
    {
        public string? Nome { get; set; } 
		public string? Cpf { get; set; } 
		public DateTime DataNascimento { get; set; }
        public long SexoId { get; set; }
        public Indicador? Sexo { get; set; }
        public string? UrlFoto { get; set; }

        public List<VoluntarioContato> Contatos { get; set; } = new();
        public long EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public long IgrejaId { get; set; }
        public Indicador? Igreja { get; set; }

        protected Voluntario() { }

        public Voluntario(string nome, string cpf, DateTime dataNascimento, long sexoId, long enderecoId, long igrejaId, string? urlFoto = null)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            SexoId = sexoId;
            UrlFoto = urlFoto;
            EnderecoId = enderecoId;
            IgrejaId = igrejaId;
        }
    }
}