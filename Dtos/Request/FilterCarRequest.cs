using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBE.Dtos.Request
{
    public class FilterCarRequest
    {
        public string? Keyword { get; set; }
        public string? Brand { get; set; }
        public string? CarType { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public string? SortBy { get; set; } // price-asc, price-desc, name-asc...
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 12;
    }
}