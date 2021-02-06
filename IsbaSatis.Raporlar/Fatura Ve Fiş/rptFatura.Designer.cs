namespace IsbaSatis.Raporlar.Fatura_Ve_Fiş
{
    partial class rptFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.colToplamTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblFaturaTarihi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIkametgah = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 29.16667F;
            this.Detail.Name = "Detail";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(749.4583F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokAdi,
            this.colMiktar,
            this.colBirimFiyat,
            this.colToplamTutar});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Multiline = true;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 1.1150399772096025D;
            // 
            // colMiktar
            // 
            this.colMiktar.Multiline = true;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.Weight = 1.066601956696116D;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Multiline = true;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Text = "colBirimFiyat";
            this.colBirimFiyat.Weight = 1.0544930502414029D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Multiline = true;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Text = "colToplamTutar";
            this.colToplamTutar.Weight = 1.1201249782260172D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFaturaTarihi,
            this.lblIkametgah,
            this.lblAdres,
            this.lblCariAdi});
            this.PageHeader.HeightF = 212.5F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblFaturaTarihi
            // 
            this.lblFaturaTarihi.LocationFloat = new DevExpress.Utils.PointFloat(531.4584F, 169F);
            this.lblFaturaTarihi.Multiline = true;
            this.lblFaturaTarihi.Name = "lblFaturaTarihi";
            this.lblFaturaTarihi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFaturaTarihi.SizeF = new System.Drawing.SizeF(238.5415F, 23F);
            this.lblFaturaTarihi.StylePriority.UseTextAlignment = false;
            this.lblFaturaTarihi.Text = "Fatura Tarihi";
            this.lblFaturaTarihi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblIkametgah
            // 
            this.lblIkametgah.LocationFloat = new DevExpress.Utils.PointFloat(531.4584F, 146F);
            this.lblIkametgah.Multiline = true;
            this.lblIkametgah.Name = "lblIkametgah";
            this.lblIkametgah.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblIkametgah.SizeF = new System.Drawing.SizeF(238.5415F, 23F);
            this.lblIkametgah.StylePriority.UseTextAlignment = false;
            this.lblIkametgah.Text = "[Semt]\\[Ilce]\\[Il]";
            this.lblIkametgah.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblAdres
            // 
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(531.4584F, 59.45832F);
            this.lblAdres.Multiline = true;
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(238.5415F, 86.54165F);
            this.lblAdres.StylePriority.UseTextAlignment = false;
            this.lblAdres.Text = "Adres";
            this.lblAdres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(560.625F, 36.45833F);
            this.lblCariAdi.Multiline = true;
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(209.375F, 23F);
            this.lblCariAdi.StylePriority.UseTextAlignment = false;
            this.lblCariAdi.Text = "Cari Adı";
            this.lblCariAdi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblGenelToplam,
            this.lblKdvToplam,
            this.lblAraToplam});
            this.PageFooter.HeightF = 73.9583F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(560.625F, 45.99997F);
            this.lblGenelToplam.Multiline = true;
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(209.375F, 23F);
            this.lblGenelToplam.StylePriority.UseTextAlignment = false;
            this.lblGenelToplam.Text = "Genel Toplam";
            this.lblGenelToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblKdvToplam
            // 
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(560.6249F, 22.99999F);
            this.lblKdvToplam.Multiline = true;
            this.lblKdvToplam.Name = "lblKdvToplam";
            this.lblKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblKdvToplam.SizeF = new System.Drawing.SizeF(209.375F, 23F);
            this.lblKdvToplam.StylePriority.UseTextAlignment = false;
            this.lblKdvToplam.Text = "Kdv Toplam";
            this.lblKdvToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(560.6249F, 0F);
            this.lblAraToplam.Multiline = true;
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(209.375F, 23F);
            this.lblAraToplam.StylePriority.UseTextAlignment = false;
            this.lblAraToplam.Text = "Ara Toplam";
            this.lblAraToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // rptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(28, 26, 100, 100);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyat;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DevExpress.XtraReports.UI.XRLabel lblFaturaTarihi;
        private DevExpress.XtraReports.UI.XRLabel lblIkametgah;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
    }
}
