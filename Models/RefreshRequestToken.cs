using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBE.Models
{
    public class RefreshRequestToken
    {
        int Id { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; internal set; }
        public int UserId { get; internal set; }
    }
}