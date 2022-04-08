using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace IsbaSatis.Raporlar.Satis
{
    public partial class rptGunlukSatis : DevExpress.XtraReports.UI.XtraReport
    {
        public rptGunlukSatis(DateTime giris)
        {
            //InitializeComponent();
            //IsbaSatisContext context = new IsbaSatisContext();
            //KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();

            //ObjectDataSource kasaDatasource = new ObjectDataSource { DataSource = kasaHareketDAL.OdemeTuruSatisListele(context,giris) };
            //this.DataSource = kasaDatasource;
            //colOdemeTuru.DataBindings.Add("Text", this.DataSource, "OdemeTuruAdi");

            //colKasaGiris.DataBindings.Add("Text", this.DataSource, "KasaGiris", "{0:C2}");
            //colKasaCikis.DataBindings.Add("Text", this.DataSource, "KasaCikis", "{0:C2}");
            //colBakiye.DataBindings.Add("Text", this.DataSource, "Bakiye", "{0:C2}");

        }

    }
}
