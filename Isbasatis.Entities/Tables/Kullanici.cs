using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
   public class Kullanici:IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public Nullable<DateTime> KayitTarihi { get; set; }
        public Nullable<DateTime> SonGirisTarihi { get; set; }

    }
}
