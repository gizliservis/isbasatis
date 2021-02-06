using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
    public class CariBakiye
    {
        public int CariId { get; set; }
        public decimal RiskLimiti { get; set; }
        public decimal Alcak { get; set; }
        public decimal Borc { get; set; }
        public decimal Bakiye { get; set; }
    }
}
