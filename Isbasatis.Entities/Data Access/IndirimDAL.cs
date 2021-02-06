using Isbasatis.Entities.Context;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Data_Access
{
    public class IndirimDAL : EntityRepoSitoryBase<IsbaSatisContext, Indirim, IndirimValidator>
    {
        public object IndirimListele(IsbaSatisContext context)
        {
            var result = (from c in context.Indirimler select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.Id,
                c.Durumu,
                c.StokKodu,
                c.Barkod,
                c.StokAdi,
                c.IndirimTuru,
                c.BaslangicTarihi,
                c.BitisTarihi,
                c.IndirimOrani,
                c.Aciklama,

            }).ToList();
            return result;
        }
        public decimal StokIndirimi(IsbaSatisContext context, string stokKodu)
        {
            decimal Sonuc = 0;
            var result = (from c in context.Indirimler.Where(c => c.StokKodu == stokKodu) select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.IndirimOrani,
            }).SingleOrDefault();
            if (result != null && result.IndirimAktif == true)
            {
                Sonuc = result.IndirimOrani;
            }
            return Sonuc;
        }
        bool Aktif(string IndirimTuru, DateTime BitisTarihi, bool Durum)
        {
            bool result = false;
            if (Durum)
            {
                if (IndirimTuru == "Suresiz")
                {
                    result = true;
                }
                else
                {
                    if (DateTime.Now <= BitisTarihi)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
