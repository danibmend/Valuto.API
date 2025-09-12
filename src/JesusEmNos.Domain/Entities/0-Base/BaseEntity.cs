using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Entities.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public Metadados Metadados { get; set; } = new();
    }

    public class Metadados
    {
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public DateTime? DataRemocao { get; set; }
        public long UsuarioCriacaoId { get; set; }
        public long UsuarioAtualizacaoId { get; set; }
        public long? UsuarioRemocaoId { get; set; }
    }
}
