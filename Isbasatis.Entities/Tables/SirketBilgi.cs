using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
   public class SirketBilgi:IEntity
    {
        public int Id { get; set; }
        public string SirketKodu { get; set; }
        public string SirketKisaAdi { get; set; }
        public string SirketUnvani { get; set; }
        public string Ulkesi { get; set; }
        public string Ili { get; set; }
        public string Ilcesi { get; set; }
        public string Semt { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string SirketTelNo { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string YetkiliKisi { get; set; }
         public string Aciklama { get; set; }
    }
}
