using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;


namespace IsbaSatis.Raporlar.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumu()
        {
            InitializeComponent();
            IsbaSatisContext context = new IsbaSatisContext();
            StokDAL stokDAL = new StokDAL();
            ObjectDataSource stokDataSource = new ObjectDataSource {DataSource=stokDAL.StokListele(context)};
            this.DataSource = stokDataSource;
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAltGrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStokBakiye");


        }

    }
}
