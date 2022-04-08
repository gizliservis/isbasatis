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
   public class BankaDAL:EntityRepoSitoryBase<IsbaSatisContext, Banka, BankaValidator>
    {
        public object BankaHrkListele(IsbaSatisContext context)
        {
            var result = context.Bankalar.GroupJoin(context.BankaHareketleri, c => c.Id, c => c.BankaId, (banka, bankaHareket) => new
            {
                banka.Id,
                banka.HesapKodu,
                banka.HesapIsmi,
                banka.HesapNo,
                banka.IbanNo,
                banka.Sube,
                banka.YetkiliAdi,
                banka.YetkiliTelefonu,
                BankaGiris = (bankaHareket.Where(c => c.BankaId == banka.Id && c.Hareket == "Banka Giriş").Sum(c => c.Tutar) ?? 0),
                BankaCikis = (bankaHareket.Where(c => c.BankaId == banka.Id && c.Hareket == "Banka Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (bankaHareket.Where(c => c.BankaId == banka.Id && c.Hareket == "Banka Giriş").Sum(c => c.Tutar) ?? 0) - (bankaHareket.Where(c => c.BankaId == banka.Id && c.Hareket == "Banka Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }
    }
}
