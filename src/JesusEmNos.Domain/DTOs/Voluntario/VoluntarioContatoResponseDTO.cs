using JesusEmNos.Domain.DTOs.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Voluntario
{
    public class VoluntarioContatoResponseDTO
    {
        public long Id { get; set; }
        public ContatoResponseDTO? Contato { get; set; }
    }
}
