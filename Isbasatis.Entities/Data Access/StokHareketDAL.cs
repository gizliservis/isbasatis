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
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.Siparis == false && c.StokId == stokId), c => c.Id, c => c.DepoId, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = ((stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) - (stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0))
            }).ToList();
            return result;
        }
        public object GetGenelStok(IsbaSatisContext context, int stokId)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.Siparis == false && c.StokId == stokId)
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
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.DepoId == depoId), c => c.Id, c => c.StokId, (Stoklar, StokHareketleri) => new
            {


                Stoklar.StokAdi,
                Stoklar.Barkod,
                StokGiris = StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0 - StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar)

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
                             StokGiris = g.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                             StokCikis = g.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                             MevcutStok = (g.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) - g.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.ToplamTutar)

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
                    KayitSayisi=context.StokHareketleri.Where(c=>c.Siparis == false && c.Irsaliye==false && c.Teklif==false &&c.DepoId==depoId && c.Hareket=="Stok Giriş").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.Siparis == false && c.Irsaliye==false && c.Teklif==false && c.DepoId==depoId && c.Hareket=="Stok Giriş").Sum(c=>c.Miktar) ?? 0
                },
                 new GenelToplam
                {
                        Bilgi="Stok Çıkış",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.Siparis == false && c.Irsaliye==false && c.Teklif==false && c.DepoId==depoId && c.Hareket=="Stok Çıkış").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.Siparis == false && c.Irsaliye==false && c.Teklif==false && c.DepoId==depoId && c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar) ?? 0
        },

    };
            return genelToplamlar;

        }
        public object StokHareketTarihAraligi(IsbaSatisContext context, DateTime baslangic, DateTime bitis)
        {
            return (from stkHareket in context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date)
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
                        Birimi = stkHareket.Stok.Birimi,
                        Barkod = stkHareket.Stok.Barkod,
                        indirimTutar = (stkHareket.BirimFiyati * stkHareket.IndirimOrani) / 100,
                        stkHareket.ToplamTutar,
                        stokIndToplam = context.StokHareketleri.Where(c => c.Siparis == false && c.Hareket != null && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.BirimFiyati * c.IndirimOrani / 100),
                        stokGiris = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.ToplamTutar),
                        stokCikis = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.ToplamTutar),
                        genelTutar = ((context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.ToplamTutar)) -
                        (context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.ToplamTutar)))
                    }).ToList();
        }
        public object StokHareketStokGrubu(IsbaSatisContext context, DateTime baslangic, DateTime bitis, string grup)
        {
            return (from stkHareket in context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup)
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
                        Birimi = stkHareket.Stok.Birimi,
                        Barkod = stkHareket.Stok.Barkod,
                        indirimTutar = (stkHareket.BirimFiyati * stkHareket.IndirimOrani) / 100,
                        stkHareket.ToplamTutar,
                        stokIndToplam = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket != null && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup).Sum(c => c.BirimFiyati * c.IndirimOrani / 100),
                        stokGiris = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup).Sum(c => c.ToplamTutar),
                        stokCikis = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup).Sum(c => c.ToplamTutar),
                        genelTutar = ((context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup).Sum(c => c.ToplamTutar)) -
                        (context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokGrubu == grup).Sum(c => c.ToplamTutar)))
                    }).ToList();
        }
        public object StokHareketStokBazli(IsbaSatisContext context, DateTime baslangic, DateTime bitis, string stok)
        {
            return (from stkHareket in context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok)
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
                        Birimi = stkHareket.Stok.Birimi,
                        Barkod = stkHareket.Stok.Barkod,
                        indirimTutar = (stkHareket.BirimFiyati * stkHareket.IndirimOrani) / 100,
                        stkHareket.ToplamTutar,
                        stokIndToplam = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket != null && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok).Sum(c => c.BirimFiyati * c.IndirimOrani / 100),
                        stokGiris = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok).Sum(c => c.ToplamTutar),
                        stokCikis = context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok).Sum(c => c.ToplamTutar),
                        genelTutar = ((context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok).Sum(c => c.ToplamTutar)) -
                        (context.StokHareketleri.Where(c => c.Siparis == false && c.Irsaliye == false && c.Teklif == false && c.Hareket == "Stok Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date && c.Stok.StokAdi == stok).Sum(c => c.ToplamTutar)))

                    }).ToList();
        }
        public object StokKarZarar(IsbaSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var result = context.StokHareketleri.Where(c => c.Hareket == "Stok Çıkış"
            && c.Siparis == false
            && c.Irsaliye == false && c.Teklif == false && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Join(context.fisler,
                hrk => hrk.FisKodu,
                cari => cari.FisKodu,
                (hrk, cari) => new
                {
                    hrk.Id,
                    hrk.FisKodu,
                    hrk.Hareket,
                    hrk.StokId,
                    hrk.Miktar,
                    hrk.Kdv,
                    hrk.BirimFiyati,
                    hrk.Tarih,
                    hrk.DepoId,
                    hrk.IndirimOrani,
                    hrk.Aciklama,
                    CariAdi=cari.Cari.CariAdi,
                    CariKodu=cari.Cari.CariKodu,
                    CariGrubu=cari.Cari.CariGrubu,
                    CariId=cari.Cari.Id,
                    IndirimTutari = (hrk.BirimFiyati * hrk.IndirimOrani) / 100,
                    StokKodu = hrk.Stok.StokKodu,
                    DepoAdi = hrk.Depo.DepoAdi,
                    Birimi = hrk.Stok.Birimi,
                    StokAdi = hrk.Stok.StokAdi,
                    Barkod = hrk.Stok.Barkod,
                    StokGrubu= hrk.Stok.StokGrubu,
                    StokAltGrubu=hrk.Stok.StokAltGrubu,
                    AlisFiyati = hrk.AlisFiyati,
                    AlisFiyati2 = hrk.AlisFiyati2,
                    AlisFiyati3 = hrk.AlisFiyati3,
                    SatisToplam = hrk.ToplamTutar,
                    AlisToplam = (hrk.AlisFiyati* hrk.Miktar),
                    AlisToplam2 = (hrk.AlisFiyati2* hrk.Miktar),
                    AlisToplam3= (hrk.AlisFiyati3* hrk.Miktar),
                    KarZarar = hrk.ToplamTutar - (hrk.AlisFiyati * hrk.Miktar),
                    KarZarar2 = hrk.ToplamTutar - (hrk.AlisFiyati2 * hrk.Miktar),
                    KarZarar3 = hrk.ToplamTutar - (hrk.AlisFiyati3 * hrk.Miktar),
                }).ToList();
            return result;
        }
    }
}
