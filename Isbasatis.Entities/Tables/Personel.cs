using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
   public class Personel:IEntity
    {
        public int Id { get; set; }
        public bool Calisiyor { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public Nullable<DateTime> IseGirisTarihi { get; set; }
        public Nullable<DateTime> IstenCikisTarihi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string CepTelefonu { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }   
        public Nullable<decimal> PrimOrani { get; set; }
        public Nullable<decimal> AylikMaasi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Fis> Fis { get; set; }
    }
}
