using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
   public class BankaHareket:IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int BankaId { get; set; }
        public Nullable<int> CariId { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
        public virtual Banka Banka { get; set; }
        public virtual Cari Cari { get; set; }
    }
}
