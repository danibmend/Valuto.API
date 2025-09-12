using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.DTOs.Base
{
    public abstract class BaseListaRetornoDTO<TResultDTO> where TResultDTO : class
    {
        public List<TResultDTO> Results { get; set; } = new List<TResultDTO>();
        public PaginationDTO? Pagination { get; set; }
    }
}
