using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBE.Models
{
    public class PaymentInformationModel
    {
        public string OrderType { get; set; }
        public double Amount { get; set; }
        public int orderid { get; set; }
        public string OrderDescription { get; set; }
        public string Name { get; set; }
    }
}