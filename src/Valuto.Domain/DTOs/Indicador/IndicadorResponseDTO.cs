﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Indicador
{
    public class IndicadorResponseDTO
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
    }
}
