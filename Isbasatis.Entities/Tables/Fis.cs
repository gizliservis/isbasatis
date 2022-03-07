using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables
{
    public class Fis : IEntity
    {
        public Fis Clone()
        {
            Fis yeniFis = new Fis();
            yeniFis.FisKodu = this.FisKodu;
            yeniFis.FisBaglantiKodu = this.FisBaglantiKodu;
            yeniFis.FisTuru = this.FisTuru;
            yeniFis.CariId = this.CariId;
            yeniFis.FaturaUnvani = this.FaturaUnvani;
            yeniFis.CepTelefonu = this.CepTelefonu;
            yeniFis.Il = this.Il;
            yeniFis.Ilce = this.Ilce;
            yeniFis.Semt = this.Semt;
            yeniFis.Adres = this.Adres;
            yeniFis.VergiDairesi = this.VergiDairesi;
            yeniFis.VergiNo = this.VergiNo;
            yeniFis.Tarih = this.Tarih;
            yeniFis.PlasiyerId = this.PlasiyerId;
            yeniFis.IskontoTutar = this.IskontoTutar;
            yeniFis.IskontoOrani = this.IskontoOrani;
            yeniFis.Alacak = this.Alacak;
            yeniFis.Borc = this.Borc;
            yeniFis.ToplamTutar = this.ToplamTutar;
            yeniFis.Aciklama = this.Aciklama;
            return yeniFis;
        }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string CariTuru { get; set; }
        public int? CariId { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime? Tarih { get; set; }
        public int? PlasiyerId { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutar { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Borc { get; set; }
        public decimal? ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public string FisBaglantiKodu { get; set; }
        public bool DepoIrsaliye { get; set; }
        public string DepoAdi { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Personel Personel { get; set; }
        public int? BankaId { get; set; }
        public virtual Banka banka { get; set; }

    }
}
