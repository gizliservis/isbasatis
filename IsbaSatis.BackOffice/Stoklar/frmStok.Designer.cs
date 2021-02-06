namespace IsbaSatis.BackOffice.AnaMenü
{
    partial class frmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStok));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantiSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 148;
            // 
            // simpleButton3
            // 
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.ImageOptions.ImageIndex = ((int)(resources.GetObject("simpleButton3.ImageOptions.ImageIndex")));
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ara32x32.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "Stok Düzenle.png");
            this.ımageList1.Images.SetKeyName(3, "Stok Ekle.png");
            this.ımageList1.Images.SetKeyName(4, "Stok Kopyala.png");
            this.ımageList1.Images.SetKeyName(5, "Stok Sil.png");
            this.ımageList1.Images.SetKeyName(6, "Kapat24x24.png");
            this.ımageList1.Images.SetKeyName(7, "folder_out.png");
            this.ımageList1.Images.SetKeyName(8, "funnel.png");
            this.ımageList1.Images.SetKeyName(9, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(10, "StokHareket.png");
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.ImageOptions.ImageIndex = ((int)(resources.GetObject("simpleButton2.ImageOptions.ImageIndex")));
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ImageOptions.ImageIndex = ((int)(resources.GetObject("simpleButton1.ImageOptions.ImageIndex")));
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.filterControl1, "filterControl1");
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.SourceControl = this.gridControl1;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
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
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkod,
            this.colBarkodTuru,
            this.colBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colMarka,
            this.colModeli,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colGarantiSuresi,
            this.colUreticiKodu,
            this.colAlisKdv,
            this.colSatisKdv,
            this.colAlisFiyati1,
            this.colAlisFiyati2,
            this.colAlisFiyati3,
            this.colSatisFiyati1,
            this.colSatisFiyati2,
            this.colSatisFiyati3,
            this.colMinStokMiktari,
            this.colMaxStokMiktari,
            this.colAciklama,
            this.colMevcutStok,
            this.colStokCikis,
            this.colStokGiris});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurumu
            // 
            resources.ApplyResources(this.colDurumu, "colDurumu");
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            // 
            // colStokKodu
            // 
            resources.ApplyResources(this.colStokKodu, "colStokKodu");
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            // 
            // colStokAdi
            // 
            resources.ApplyResources(this.colStokAdi, "colStokAdi");
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            // 
            // colBarkod
            // 
            resources.ApplyResources(this.colBarkod, "colBarkod");
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            // 
            // colBarkodTuru
            // 
            resources.ApplyResources(this.colBarkodTuru, "colBarkodTuru");
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            // 
            // colBirimi
            // 
            resources.ApplyResources(this.colBirimi, "colBirimi");
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            // 
            // colStokGrubu
            // 
            resources.ApplyResources(this.colStokGrubu, "colStokGrubu");
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.OptionsColumn.AllowEdit = false;
            // 
            // colStokAltGrubu
            // 
            resources.ApplyResources(this.colStokAltGrubu, "colStokAltGrubu");
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.OptionsColumn.AllowEdit = false;
            // 
            // colMarka
            // 
            resources.ApplyResources(this.colMarka, "colMarka");
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            // 
            // colModeli
            // 
            resources.ApplyResources(this.colModeli, "colModeli");
            this.colModeli.FieldName = "Modeli";
            this.colModeli.Name = "colModeli";
            this.colModeli.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod1
            // 
            resources.ApplyResources(this.colOzelKod1, "colOzelKod1");
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod2
            // 
            resources.ApplyResources(this.colOzelKod2, "colOzelKod2");
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod3
            // 
            resources.ApplyResources(this.colOzelKod3, "colOzelKod3");
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod4
            // 
            resources.ApplyResources(this.colOzelKod4, "colOzelKod4");
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            // 
            // colGarantiSuresi
            // 
            resources.ApplyResources(this.colGarantiSuresi, "colGarantiSuresi");
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            this.colGarantiSuresi.OptionsColumn.AllowEdit = false;
            // 
            // colUreticiKodu
            // 
            resources.ApplyResources(this.colUreticiKodu, "colUreticiKodu");
            this.colUreticiKodu.FieldName = "UreticiKodu";
            this.colUreticiKodu.Name = "colUreticiKodu";
            this.colUreticiKodu.OptionsColumn.AllowEdit = false;
            // 
            // colAlisKdv
            // 
            resources.ApplyResources(this.colAlisKdv, "colAlisKdv");
            this.colAlisKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colAlisKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            this.colAlisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colSatisKdv
            // 
            resources.ApplyResources(this.colSatisKdv, "colSatisKdv");
            this.colSatisKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colSatisKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            this.colSatisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyati1
            // 
            resources.ApplyResources(this.colAlisFiyati1, "colAlisFiyati1");
            this.colAlisFiyati1.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati1.FieldName = "AlisFiyati1";
            this.colAlisFiyati1.Name = "colAlisFiyati1";
            this.colAlisFiyati1.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyati2
            // 
            resources.ApplyResources(this.colAlisFiyati2, "colAlisFiyati2");
            this.colAlisFiyati2.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati2.FieldName = "AlisFiyati2";
            this.colAlisFiyati2.Name = "colAlisFiyati2";
            this.colAlisFiyati2.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyati3
            // 
            resources.ApplyResources(this.colAlisFiyati3, "colAlisFiyati3");
            this.colAlisFiyati3.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati3.FieldName = "AlisFiyati3";
            this.colAlisFiyati3.Name = "colAlisFiyati3";
            this.colAlisFiyati3.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyati1
            // 
            resources.ApplyResources(this.colSatisFiyati1, "colSatisFiyati1");
            this.colSatisFiyati1.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati1.FieldName = "SatisFiyati1";
            this.colSatisFiyati1.Name = "colSatisFiyati1";
            this.colSatisFiyati1.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyati2
            // 
            resources.ApplyResources(this.colSatisFiyati2, "colSatisFiyati2");
            this.colSatisFiyati2.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati2.FieldName = "SatisFiyati2";
            this.colSatisFiyati2.Name = "colSatisFiyati2";
            this.colSatisFiyati2.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyati3
            // 
            resources.ApplyResources(this.colSatisFiyati3, "colSatisFiyati3");
            this.colSatisFiyati3.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati3.FieldName = "SatisFiyati3";
            this.colSatisFiyati3.Name = "colSatisFiyati3";
            this.colSatisFiyati3.OptionsColumn.AllowEdit = false;
            // 
            // colMinStokMiktari
            // 
            resources.ApplyResources(this.colMinStokMiktari, "colMinStokMiktari");
            this.colMinStokMiktari.FieldName = "MinStokMiktari";
            this.colMinStokMiktari.Name = "colMinStokMiktari";
            this.colMinStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colMaxStokMiktari
            // 
            resources.ApplyResources(this.colMaxStokMiktari, "colMaxStokMiktari");
            this.colMaxStokMiktari.FieldName = "MaxStokMiktari";
            this.colMaxStokMiktari.Name = "colMaxStokMiktari";
            this.colMaxStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colAciklama
            // 
            resources.ApplyResources(this.colAciklama, "colAciklama");
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            // 
            // colMevcutStok
            // 
            resources.ApplyResources(this.colMevcutStok, "colMevcutStok");
            this.colMevcutStok.FieldName = "MevcutStok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.OptionsColumn.AllowEdit = false;
            // 
            // colStokCikis
            // 
            resources.ApplyResources(this.colStokCikis, "colStokCikis");
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.OptionsColumn.AllowEdit = false;
            // 
            // colStokGiris
            // 
            resources.ApplyResources(this.colStokGiris, "colStokGiris");
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.OptionsColumn.AllowEdit = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblBaslik.Appearance.Font")));
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.lblBaslik, "lblBaslik");
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.Stok_Kartı32x32;
            this.lblBaslik.Name = "lblBaslik";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnHareket);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnKopyala);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            resources.ApplyResources(this.grpMenu, "grpMenu");
            this.grpMenu.Name = "grpMenu";
            // 
            // btnHareket
            // 
            this.btnHareket.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnHareket.ImageOptions.ImageIndex")));
            this.btnHareket.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnHareket, "btnHareket");
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Click += new System.EventHandler(this.btnStokHareket_Click);
            // 
            // btnKapat
            // 
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnKapat.ImageOptions.ImageIndex")));
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnAra.ImageOptions.ImageIndex")));
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnAra, "btnAra");
            this.btnAra.Name = "btnAra";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnGuncelle.ImageOptions.ImageIndex")));
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnGuncelle, "btnGuncelle");
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnKopyala.ImageOptions.ImageIndex")));
            this.btnKopyala.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnKopyala, "btnKopyala");
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnSil.ImageOptions.ImageIndex")));
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnDuzenle.ImageOptions.ImageIndex")));
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnDuzenle, "btnDuzenle");
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = ((int)(resources.GetObject("btnEkle.ImageOptions.ImageIndex")));
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmStok
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStok";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModeli;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantiSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutStok;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraEditors.SimpleButton btnHareket;
    }
}