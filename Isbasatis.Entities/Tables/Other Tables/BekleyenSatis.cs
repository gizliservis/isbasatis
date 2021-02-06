using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables.Other_Tables
{
   public class BekleyenSatis
    {
        public int Id { get; set; }
        public Fis BekeleyenFis { get; set; }
        public decimal OdenenTutar { get; set; }
        public List<StokHareket> StokHareketi { get; set; }
        public List<KasaHareket> KasaHareketi { get; set; }

    }
}
