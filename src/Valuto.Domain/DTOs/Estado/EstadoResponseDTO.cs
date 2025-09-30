using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Estado
{
    public class EstadoResponseDTO
    {
        public long Id { get; set; }
        public string? Sigla { get; set; }
        public string? Nome { get; set; }
    }
}
