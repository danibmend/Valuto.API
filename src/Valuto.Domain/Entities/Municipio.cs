using Valuto.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Entities
{
    public class Municipio : BaseEntity
    {
        public string? CodIbge7 { get; set; } 
        public string? Nome { get; set; } 
        public long EstadoId { get; set; } 
        public Estado? Estado { get; set; }

        protected Municipio() { }

        public Municipio(string codIbge7, string nome, long estadoId)
        {
            CodIbge7 = codIbge7;
            Nome = nome;
            EstadoId = estadoId;
        }
    }
}
