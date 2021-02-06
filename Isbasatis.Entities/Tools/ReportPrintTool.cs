using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tools
{
    public class ReporPrintTool
    {
        public enum Belge
        {
            BilgiFisi,
            Fatura,
            Diger
        }
        public void RoporYazdir(XtraReport rapor,Belge belge)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            string yaziciAdi=null;
            int ayar=0;
            switch (belge)
            {
                case Belge.BilgiFisi:
                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                    break;
                case Belge.Fatura:
                    ayar =Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                    break;
                case Belge.Diger:
                    break;
                default:
                    break;
            }
            switch (ayar)
            {
                case 0:
                    raporYazdir.Print(yaziciAdi);
                    break;
                case 1:
                    raporYazdir.PrintDialog();
                    break;
                case 2:
                    raporYazdir.ShowPreviewDialog();
                    break;
            }

        }
    }
}
