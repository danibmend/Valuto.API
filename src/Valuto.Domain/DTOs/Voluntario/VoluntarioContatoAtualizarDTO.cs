using Valuto.Domain.DTOs.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Voluntario
{
    public class VoluntarioContatoAtualizarDTO
    {
        public long Id { get; set; }
        public ContatoDTO? Contato { get; set; }
    }
}
