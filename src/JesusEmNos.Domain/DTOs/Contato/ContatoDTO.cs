using JesusEmNos.Domain.DTOs.Indicador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Contato
{
    public class ContatoDTO
    {
        public string? Valor { get; set; }
        public IndicadorDTO? TipoContato { get; set; }
        public IndicadorDTO? Classificacao { get; set; }
    }
}
