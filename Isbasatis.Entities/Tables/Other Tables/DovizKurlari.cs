using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables.Other_Tables
{
  public class DovizKurlari
    {
        public string CurrencyCode { get; set; }
        public string Isim { get; set; }
        public Nullable<decimal> ForexBuying { get; set; }
        public Nullable<decimal> ForexSelling { get; set; }
        public Nullable<decimal> BanknoteBuying { get; set; }
        public Nullable<decimal> BanknoteSelling { get; set; }
    }
}
