﻿
namespace IsbaSatis.BackOffice.Raporlar
{
    partial class frmCariBakiyeRaporu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRiskLimiti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1049, 509);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colYetkiliKisi,
            this.colFaturaUnvani,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEMail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colCariGrubu,
            this.colCariAltGrubu,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colIskontoOrani,
            this.colRiskLimiti,
            this.colAlisOzelFiyati,
            this.colSatisOzelFiyati,
            this.colAciklama,
            this.colAlacak,
            this.colBorc,
            this.colBakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Cari Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 89;
            // 
            // colCariTuru
            // 
            this.colCariTuru.Caption = "Cari Türü";
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.OptionsColumn.AllowEdit = false;
            this.colCariTuru.Visible = true;
            this.colCariTuru.VisibleIndex = 1;
            this.colCariTuru.Width = 79;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 2;
            this.colCariKodu.Width = 56;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CariAdi", "Cari Sayısı : {0}")});
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            this.colCariAdi.Width = 143;
            // 
            // colYetkiliKisi
            // 
            this.colYetkiliKisi.Caption = "Yetkili Kişi";
            this.colYetkiliKisi.FieldName = "YetkiliKisi";
            this.colYetkiliKisi.Name = "colYetkiliKisi";
            this.colYetkiliKisi.OptionsColumn.AllowEdit = false;
            this.colYetkiliKisi.Visible = true;
            this.colYetkiliKisi.VisibleIndex = 5;
            this.colYetkiliKisi.Width = 65;
            // 
            // colFaturaUnvani
            // 
            this.colFaturaUnvani.Caption = "Fatura Ünvanı";
            this.colFaturaUnvani.FieldName = "FaturaUnvani";
            this.colFaturaUnvani.Name = "colFaturaUnvani";
            this.colFaturaUnvani.OptionsColumn.AllowEdit = false;
            this.colFaturaUnvani.Visible = true;
            this.colFaturaUnvani.VisibleIndex = 6;
            this.colFaturaUnvani.Width = 86;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E - Mail";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.OptionsColumn.AllowEdit = false;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Adresi";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            // 
            // colCariGrubu
            // 
            this.colCariGrubu.Caption = "Cari Grubu";
            this.colCariGrubu.FieldName = "CariGrubu";
            this.colCariGrubu.Name = "colCariGrubu";
            this.colCariGrubu.OptionsColumn.AllowEdit = false;
            this.colCariGrubu.Visible = true;
            this.colCariGrubu.VisibleIndex = 4;
            this.colCariGrubu.Width = 78;
            // 
            // colCariAltGrubu
            // 
            this.colCariAltGrubu.Caption = "Cari Alt Grubu";
            this.colCariAltGrubu.FieldName = "CariAltGrubu";
            this.colCariAltGrubu.Name = "colCariAltGrubu";
            this.colCariAltGrubu.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.Caption = "İskonto Oranı";
            this.colIskontoOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIskontoOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsColumn.AllowEdit = false;
            // 
            // colRiskLimiti
            // 
            this.colRiskLimiti.Caption = "Risk Limiti";
            this.colRiskLimiti.DisplayFormat.FormatString = "C2";
            this.colRiskLimiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRiskLimiti.FieldName = "RiskLimiti";
            this.colRiskLimiti.Name = "colRiskLimiti";
            this.colRiskLimiti.OptionsColumn.AllowEdit = false;
            // 
            // colAlisOzelFiyati
            // 
            this.colAlisOzelFiyati.Caption = "Alış Özel Fiyatı";
            this.colAlisOzelFiyati.FieldName = "AlisOzelFiyati";
            this.colAlisOzelFiyati.Name = "colAlisOzelFiyati";
            this.colAlisOzelFiyati.OptionsColumn.AllowEdit = false;
            // 
            // colSatisOzelFiyati
            // 
            this.colSatisOzelFiyati.Caption = "Satış Özel Fiyatı";
            this.colSatisOzelFiyati.FieldName = "SatisOzelFiyati";
            this.colSatisOzelFiyati.Name = "colSatisOzelFiyati";
            this.colSatisOzelFiyati.OptionsColumn.AllowEdit = false;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "Alacak";
            this.colAlacak.DisplayFormat.FormatString = "C2";
            this.colAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.OptionsColumn.AllowEdit = false;
            this.colAlacak.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", "Alacak={0:C2}")});
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 7;
            this.colAlacak.Width = 68;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "Borç";
            this.colBorc.DisplayFormat.FormatString = "C2";
            this.colBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.OptionsColumn.AllowEdit = false;
            this.colBorc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", "Borç={0:C2}")});
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 8;
            this.colBorc.Width = 68;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bakiye", "Bakiye={0:C2}")});
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 9;
            this.colBakiye.Width = 162;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.Location = new System.Drawing.Point(670, 6);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 7;
            this.dropDownButton1.Text = "Dışarı Çıkart";
            // 
            // frmCariBakiyeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 509);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCariBakiyeRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Bakiye Raporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKisi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colCariGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colRiskLimiti;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}