using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
   public class StokHareket : IEntity
    {
        public StokHareket clone()
        {
            StokHareket yeniHareket = new StokHareket();
           yeniHareket.FisKodu = this.FisKodu;
           yeniHareket.Hareket = this.Hareket;
           yeniHareket.StokId = this.StokId;
           yeniHareket.Miktar = this.Miktar;
           yeniHareket.Kdv = this.Kdv;
           yeniHareket.BirimFiyati = this.BirimFiyati;
           yeniHareket.IndirimOrani = this.IndirimOrani;
           yeniHareket.ToplamTutar = this.ToplamTutar;
           yeniHareket.DepoId = this.DepoId;
           yeniHareket.SeriNo = this.SeriNo;
           yeniHareket.Tarih = this.Tarih;
           yeniHareket.Siparis = this.Siparis;
           yeniHareket.Aciklama = this.Aciklama;
           yeniHareket.Irsaliye = this.Irsaliye;
           yeniHareket.Teklif = this.Teklif;
            return yeniHareket;
        }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisBaglantiKodu { get; set; }
        public string Hareket { get; set; }
        public int StokId { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public int DepoId { get; set; }
       
        public string SeriNo { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public bool Siparis { get; set; }
        public bool Irsaliye { get; set; }
        public bool Teklif { get; set; }
        public string Aciklama { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual Depo Depo { get; set; }
    }
}
