using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using DevExpress.DataAccess.ObjectBinding;
using Isbasatis.Entities.Tables;

namespace IsbaSatis.Raporlar.Fatura_Ve_Fiş
{
    public partial class rptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFatura(string fisKodu)
        {
            InitializeComponent();
            IsbaSatisContext context = new IsbaSatisContext();
            StokHareketDAL stokHareketDAL = new StokHareketDAL();
            FisDAL fisDAL = new FisDAL();
            Fis fisBilgi =fisDAL.GetByFilter(context,c=>c.FisKodu==fisKodu);
            
            ObjectDataSource stokHareketDatasource = new ObjectDataSource { DataSource = stokHareketDAL.GetAll(context,c=>c.FisKodu==fisKodu)};
            this.DataSource = stokHareketDatasource;

            lblCariAdi.Text = fisBilgi.Cari.CariAdi;
            lblAdres.Text = fisBilgi.Adres;
            lblIkametgah.Text = fisBilgi.Semt + "\\" + fisBilgi.Ilce + "\\" + fisBilgi.Il;
            lblFaturaTarihi.Text = fisBilgi.Tarih.ToString();

            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");

           CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutari";
            calcIndirimTutari.Expression = "([BirimFiyati] * [Miktar]) / 100 * [IndirimOrani] ";

            CalculatedField calcKdvToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvToplam);
            calcKdvToplam.Name = "KdvTutari";
            calcKdvToplam.Expression = "([BirimFiyati] * [Miktar]-[IndirimTutari]) / 100 * [Kdv] ";

 


    

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati] * [Miktar]) - [KdvTutari] - [IndirimTutari] ";


        CalculatedField calcKdvliTutar = new CalculatedField();
            this.CalculatedFields.Add(calcKdvliTutar);
            calcKdvliTutar.Name = "KdvDahil";
            calcKdvliTutar.Expression = "([BirimFiyati] * [Miktar]) - [IndirimTutari]";

            colToplamTutar.DataBindings.Add("Text", null, "Tutar");

            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Page;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Page;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Page;
            sumGenelToplam.FormatString = "{0:C2}";

            lblAraToplam.DataBindings.Add("Text", null, "Tutar", "{0:C2}");
            lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari", "{0:C2}");
            lblGenelToplam.DataBindings.Add("Text", null, "KdvDahil", "{0:C2}");
            lblAraToplam.Summary = sumAraToplam;
            lblKdvToplam.Summary = sumKdvToplam;
            lblGenelToplam.Summary = sumGenelToplam;

        }

    }
}
