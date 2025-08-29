using JesusEmNos.Domain.DTOs.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Municipio
{
    public class MunicipioResponseDTO
    {
        public long Id { get; set; }
        public string? CodIbge7 { get; set; }
        public string? Nome { get; set; }
        public EstadoResponseDTO? Estado { get; set; }
    }
}
