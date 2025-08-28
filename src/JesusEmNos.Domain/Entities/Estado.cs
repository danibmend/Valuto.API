using JesusEmNos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities
{
    public class Estado : BaseEntity
    {
        public string? Sigla { get; set; } 
        public string? Nome { get; set; } 

        public List<Municipio> Municipios { get; set; } = new();

        protected Estado() { }

        public Estado(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }
    }
}
