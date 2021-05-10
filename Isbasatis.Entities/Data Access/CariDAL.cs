using Isbasatis.Entities.Context;
using Isbasatis.Entities.Interfaces;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Data_Access
{
    public class CariDAL : EntityRepoSitoryBase<IsbaSatisContext, Cari, CariValidator>
    {

        public object CariListele(IsbaSatisContext context)
        {
            var result = context.Cariler.GroupJoin(context.fisler, c => c.Id, c => c.CariId, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak = fisler.Sum(c => c.Alacak) ?? 0,
                Borc = fisler.Sum(c => c.Borc) ?? 0,
                Bakiye = fisler.Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0)).Sum() ?? 0
            }).ToList();
            return result;
        }
        public object CariFisAyrinti(IsbaSatisContext context, int cariId)
        {
            return (from fis in context.fisler.Where(c => c.CariId == cariId)
                    select new
                    {
                        fis.Id,
                        fis.FisKodu,
                        fis.FisTuru,
                        fis.BelgeNo,
                        fis.Tarih,
                        fis.IskontoOrani,
                        fis.IskontoTutar,
                        fis.Aciklama,
                        fis.Alacak,
                        fis.Borc,
                        Bakiye = context.fisler.OrderBy(c => c.Tarih).ThenBy(c => c.Id).Where(c => c.CariId == cariId && c.Tarih <= fis.Tarih && c.Id >= fis.Id).Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0)).Sum() ?? 0
                    }).OrderBy(c => c.Tarih).ToList();
        }
        public object CariFisAyrintiGenelToplam(IsbaSatisContext context, int cariId)
        {
            var result = (from c in context.fisler.Where(c => c.CariId == cariId)
                          group c by new
                          {
                              c.FisTuru

                          } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              Tutar = grp.Sum(c => c.Alacak ?? c.Borc)
                          }).ToList();
            return result;
        }
        public object CariGenelToplam(IsbaSatisContext context, int cariId)
        {
            decimal alacak = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Alacak) ?? 0;
            decimal borc = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Borc) ?? 0;
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Alacak",
                    Tutar=alacak
                },
                 new GenelToplam
                {
                    Bilgi="Borç",
                    Tutar=borc
        },
                  new GenelToplam
                {
                    Bilgi="Bakiye",
                    Tutar=alacak-borc
        }
    };
            return genelToplamlar;

        }
        public CariBakiye CariBakiyesi(IsbaSatisContext context, int cariId)
        {
            decimal alacak = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Alacak) ?? 0;
            decimal borc = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Borc) ?? 0;

            CariBakiye entity = new CariBakiye
            {
                CariId = cariId,
                RiskLimiti = Convert.ToDecimal(context.Cariler.SingleOrDefault(c => c.Id == cariId).RiskLimiti),
                Alcak = alacak,
                Borc = borc,
                Bakiye = alacak - borc
            };
            return entity;
        }
    }
}
