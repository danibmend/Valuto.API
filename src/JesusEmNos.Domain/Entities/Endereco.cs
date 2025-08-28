using JesusEmNos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public string? Logradouro { get; set; } 
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }

        public long TipoEnderecoId { get; set; }
        public Indicador? TipoEndereco { get; set; }
        public long MunicipioId { get; set; }
        public Municipio? Municipio { get; set; }

        protected Endereco() { }

        public Endereco(string logradouro, string numero, string bairro, string cep, long tipoEnderecoId, long municipioId, string? complemento = null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            TipoEnderecoId = tipoEnderecoId;
            MunicipioId = municipioId;
        }
    }
}
