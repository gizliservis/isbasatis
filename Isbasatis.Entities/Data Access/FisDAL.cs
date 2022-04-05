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

    public class FisDAL : EntityRepoSitoryBase<IsbaSatisContext, Fis, FisValidator>
    {

        public object AlisFaturaListele(IsbaSatisContext context, string fisturu, DateTime baslangic, DateTime bitis)
        {
            return (from fis in context.fisler.Where(c => c.FisTuru == fisturu && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date)
                    select new
                    {
                        fis.Id,
                        fis.Tarih,
                        fis.FisKodu,
                        fis.FisTuru,
                        fis.CariId,
                        fis.Cari.CariAdi,
                        fis.Cari.CariKodu,
                        fis.BelgeNo,
                        fis.IskontoOrani,
                        fis.IskontoTutar,
                        fis.Aciklama,
                        fis.Alacak,
                        fis.Borc,
                        fis.ToplamTutar,
                    }).ToList();
        }
        public object CariEkstre(IsbaSatisContext context, int cariId, DateTime baslangic, DateTime bitis)
        {
            return (from fis in context.fisler.Where(c => c.CariId == cariId && DbFunctions.TruncateTime(c.Tarih) >= baslangic.Date && DbFunctions.TruncateTime(c.Tarih) <= bitis.Date)
                    select new
                    {
                        fis.Id,
                        fis.Tarih,
                        fis.FisKodu,
                        fis.FaturaUnvani,
                        fis.CepTelefonu,
                        fis.Il,
                        fis.Ilce,
                        fis.FisTuru,
                        fis.CariId,
                        CariAdi = fis.Cari.CariAdi,
                        CariKodu = fis.Cari.CariKodu,
                        fis.BelgeNo,
                        fis.IskontoOrani,
                        fis.IskontoTutar,
                        fis.Aciklama,
                        fis.Alacak,
                        fis.Borc,
                        fis.ToplamTutar,
                    }).ToList();
        }
    }
}
