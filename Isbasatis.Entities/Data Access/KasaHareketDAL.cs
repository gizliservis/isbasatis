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
    public class KasaHareketDAL : EntityRepoSitoryBase<IsbaSatisContext, KasaHareket, KasaHareketValidator>
    {
        public object OdemeTuruSatisListele(IsbaSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.Id, c => c.OdemeTuruId, (odemeturu, kasahareket) => new
            {
                odemeturu.Id,
                odemeturu.OdemeTuruKodu,
                odemeturu.OdemeTuruAdi,
                odemeturu.Aciklama,
                KasaGiris = (kasahareket.Where(c => c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Giriş" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.Tutar) ?? 0),
                KasaCikis = (kasahareket.Where(c => c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.Tutar) ?? 0),
                Bakiye = (kasahareket.Where(c => c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Giriş"&& DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Çıkış" && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }
    }
}
