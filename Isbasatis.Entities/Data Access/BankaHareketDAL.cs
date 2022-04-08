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
   public class BankaHareketDAL: EntityRepoSitoryBase<IsbaSatisContext, BankaHareket, BankaHareketValidator>
    {
        public object BankaHareketleri(IsbaSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var result = context.fisler.Where(c=>DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date).Join(context.BankaHareketleri.Where(c => DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date), c => c.FisKodu, c => c.FisKodu, (fisler, bankahareket) => new
            {
               fisler.FisTuru,
               fisler.FisKodu,
               fisler.Alacak,
               fisler.Tarih,
               fisler.Borc,
               fisler.ToplamTutar,
               fisler.BankaId,
               Bankasi=fisler.banka.Bankasi,
               HesapKodu=fisler.banka.HesapKodu,
               HesapIsmi=fisler.banka.HesapIsmi,
               HesapNo=fisler.banka.HesapNo,
               Sube=fisler.banka.Sube,
               IbanNo=fisler.banka.IbanNo,
               YetkiliAdi=fisler.banka.YetkiliAdi,
               YetkiliTelefonu=fisler.banka.YetkiliTelefonu,
               CariAdi=bankahareket.Cari.CariAdi,
               CariKodu=bankahareket.Cari.CariKodu,
               CariId=bankahareket.CariId

               
               
            }).ToList();
            return result;
        }
    }
}
