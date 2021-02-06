using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tools
{
  public static class ConverterTool
    {
        private static StokHareket StokToStokHareket(IsbaSatisContext context,Isbasatis.Entities.Tables.Stok entity,decimal miktar)

        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDAL = new IndirimDAL();
            stokHareket.StokId = entity.Id;
            stokHareket.DepoId =Convert.ToInt32( SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
         //   stokHareket.BirimFiyati = txtFisturu.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = miktar;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.IndirimOrani = indirimDAL.StokIndirimi(context, entity.StokKodu);
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }
        public static decimal StringToDecimal(string ifade,string ondalikAyrac)
        {
            string ondalikKarekter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(ondalikAyrac, ondalikKarekter));
        }
    }
}
