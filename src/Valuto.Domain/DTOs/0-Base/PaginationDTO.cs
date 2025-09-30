using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Base
{
    public class PaginationDTO
    {
        public long TotalPages => PageSize == 0 ? 0 : (TotalItems % PageSize == 0 ? TotalItems / PageSize : TotalItems / PageSize + 1);
        public long TotalItems { get; set; }
        public int Page { get; set; }

        public int PageSize { get; set; }

        public string? Order { get; set; }
        public string? SortOrder { get; set; }
    }
}
