using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Entities;
using ProjectBE.Entities;

namespace Project.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public virtual OrderStatusEnum Status { get; set; }
        public Guid CodeOrder { get; set; }

    }
}