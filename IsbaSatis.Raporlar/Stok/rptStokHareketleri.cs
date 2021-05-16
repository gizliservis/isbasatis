using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using DevExpress.DataAccess.ObjectBinding;

namespace IsbaSatis.Raporlar.Stok
{
    public partial class rptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokHareketleri(DateTime baslangic,DateTime bitis)
        {
            InitializeComponent();
            IsbaSatisContext context = new IsbaSatisContext();
            StokHareketDAL stokHareketDAL = new StokHareketDAL();
            ObjectDataSource dataSource = new ObjectDataSource {DataSource=stokHareketDAL.StokHareketTarihAraligi(context,baslangic,bitis)};
            this.DataSource = dataSource;
            colHareketi.DataBindings.Add("Text", this.DataSource, "Hareket");
            colTarih.DataBindings.Add("Text", this.DataSource, "Tarih");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colKdv.DataBindings.Add("Text", this.DataSource, "Kdv", "{0:'%'0}");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati", "{0:C2}");
            colIndirimOrani.DataBindings.Add("Text", this.DataSource, "IndirimOrani", "{0:'%'0}");
            colIndirimTutar.DataBindings.Add("Text", null, "indirimTutar", "{0:C2}");
            colTutar.DataBindings.Add("Text", this.DataSource, "ToplamTutar", "{0:C2}");
            lblToplamTutar.DataBindings.Add("Text", this.DataSource, "genelTutar", "{0:C2}");
            lblIndirimTutar.DataBindings.Add("Text", null, "stokIndToplam", "{0:C2}");

        }

    }
}
