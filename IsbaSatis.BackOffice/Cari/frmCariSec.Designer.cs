namespace IsbaSatis.BackOffice.Cari
{
    partial class frmCariSec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariSec));
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
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.btnStokSec = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1066, 471);
            this.gridControl1.TabIndex = 1;
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
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 9;
            this.colBakiye.Width = 162;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.lblUyari);
            this.grpMenu.Controls.Add(this.btnStokSec);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 440);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1066, 87);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUyari.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.information;
            this.lblUyari.Location = new System.Drawing.Point(5, 26);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(441, 49);
            this.lblUyari.TabIndex = 1;
            this.lblUyari.Text = "Çoklu Seçim Yapabilmek  İçin CTRL Tuşuna Basarak Seçim Yapın";
            this.lblUyari.Visible = false;
            // 
            // btnStokSec
            // 
            this.btnStokSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStokSec.ImageOptions.ImageIndex = 0;
            this.btnStokSec.ImageOptions.ImageList = this.ımageList1;
            this.btnStokSec.Location = new System.Drawing.Point(884, 23);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(90, 62);
            this.btnStokSec.TabIndex = 0;
            this.btnStokSec.Text = "Seç";
            this.btnStokSec.Click += new System.EventHandler(this.btnStokSec_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kaydet24x24.png");
            this.ımageList1.Images.SetKeyName(1, "Kapat24x24.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(974, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 62);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.user;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1066, 56);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Cari Seçim Ekranı";
            // 
            // btnAra
            // 
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(809, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 62);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmCariSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 527);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCariSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Seçim Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCariSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.LabelControl lblUyari;
        private DevExpress.XtraEditors.SimpleButton btnStokSec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}