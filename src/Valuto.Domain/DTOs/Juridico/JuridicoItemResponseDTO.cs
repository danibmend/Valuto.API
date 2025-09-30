using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Juridico
{
    public class JuridicoItemResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CpfResponsavel { get; set; }
        public string? UrlFoto { get; set; }
    }
}
