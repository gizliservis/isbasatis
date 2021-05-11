using Isbasatis.Entities.Context;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Data_Access
{
    public class StokHareketDAL : EntityRepoSitoryBase<IsbaSatisContext, StokHareket, StokHareketValidator>
    {
        public object GetDepoStok(IsbaSatisContext context, int stokId)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokId == stokId), c => c.Id, c => c.DepoId, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = ((stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0))
            }).ToList();
            return result;
        }
        public object GetGenelStok(IsbaSatisContext context, int stokId)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokId == stokId)
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }
        public object DepoStokListele(IsbaSatisContext context, int depoId)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c => c.DepoId == depoId), c => c.Id, c => c.StokId, (Stoklar, StokHareketleri) => new
            {


                Stoklar.StokAdi,
                Stoklar.Barkod,
                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0 - StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar)

            }).ToList();
            return tablo;

        }
        public object DepoStokListele1(IsbaSatisContext context)
        {
            var tablo = (from c in context.StokHareketleri
                         group c by new { c.Stok, c.Depo } into g
                         select new
                         {

                             DepoKodu = g.Key.Depo.DepoKodu,
                             DepoAdi = g.Key.Depo.DepoAdi,
                             Barkod = g.Key.Stok.Barkod,
                             StokKodu = g.Key.Stok.StokKodu,
                             StokAdi = g.Key.Stok.StokAdi,
                             StokGiris = g.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                             StokCikis = g.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                             MevcutStok = (g.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) - g.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.ToplamTutar)

                         }).ToList();
            return tablo;

        }
        public object DepoIstatistikListele(IsbaSatisContext context, int depoId)
        {

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Stok Giriş",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoId==depoId && c.Hareket=="Stok Giriş").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoId==depoId && c.Hareket=="Stok Giriş").Sum(c=>c.Miktar) ?? 0
                },
                 new GenelToplam
                {
                        Bilgi="Stok Çıkış",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoId==depoId && c.Hareket=="Stok Çıkış").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoId==depoId && c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar) ?? 0
        },

    };
            return genelToplamlar;

        }
        public object StokHareketTarihAraligi(IsbaSatisContext context, DateTime baslangic, DateTime bitis)
        {
            return (from stkHareket in context.StokHareketleri.Where(c => DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date)
                    select new
                    {

                        stkHareket.Id,
                        stkHareket.StokId,
                        stkHareket.FisKodu,
                        stkHareket.Hareket,
                        StokAdi = stkHareket.Stok.StokAdi,
                        StokKodu = stkHareket.Stok.StokKodu,
                        stkHareket.Miktar,
                        stkHareket.Kdv,
                         stkHareket.BirimFiyati,
                        stkHareket.IndirimOrani,
                        stkHareket.DepoId,
                        DepoAdi = stkHareket.Depo.DepoAdi,
                        DepoKodu = stkHareket.Depo.DepoKodu,
                        stkHareket.SeriNo,
                        stkHareket.Tarih,
                        stkHareket.Aciklama,
                       Birimi= stkHareket.Stok.Birimi,
                       Barkod= stkHareket.Stok.Barkod,
                        GenelToplam = (stkHareket.BirimFiyati * stkHareket.Miktar) - (stkHareket.Miktar * stkHareket.BirimFiyati * stkHareket.IndirimOrani / 100)
                    }).ToList();
        }
    }
}
