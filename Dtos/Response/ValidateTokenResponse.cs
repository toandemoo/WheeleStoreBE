using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBE.Dtos.Response
{
    public class ValidateTokenResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Email { get; set; }
    }
}