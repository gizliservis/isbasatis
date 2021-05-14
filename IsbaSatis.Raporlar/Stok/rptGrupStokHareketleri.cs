using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace IsbaSatis.Raporlar.Stok
{
    public partial class rptGrupStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        public rptGrupStokHareketleri(DateTime baslangic, DateTime bitis,string grup)
        {
            InitializeComponent();
            IsbaSatisContext context = new IsbaSatisContext();
            StokHareketDAL stokHareketDAL = new StokHareketDAL();
            ObjectDataSource dataSource = new ObjectDataSource { DataSource = stokHareketDAL.StokHareketStokGrubu(context, baslangic, bitis, grup) };
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

            CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutar";
            calcIndirimTutari.Expression = "([BirimFiyati] * [Miktar]) / 100 * [IndirimOrani] ";

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati] * [Miktar]) - [IndirimTutar]";

            colIndirimTutar.DataBindings.Add("Text", null, "IndirimTutar", "{0:C2}");
            colTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumIndirimTutari = new XRSummary();
            sumIndirimTutari.Func = SummaryFunc.Sum;
            sumIndirimTutari.Running = SummaryRunning.Group;
            sumIndirimTutari.FormatString = "{0:C2}";

            XRSummary sumToplamTutar = new XRSummary();
            sumToplamTutar.Func = SummaryFunc.Sum;
            sumToplamTutar.Running = SummaryRunning.Group;
            sumToplamTutar.FormatString = "{0:C2}";
            lblIndirimTutar.Summary = sumIndirimTutari;
            lblToplamTutar.Summary = sumToplamTutar;


            lblIndirimTutar.DataBindings.Add("Text", null, "IndirimTutar", "{0:C2}");
            lblToplamTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");
        }

    }
}
