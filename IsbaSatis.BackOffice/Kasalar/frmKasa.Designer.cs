namespace IsbaSatis.BackOffice.Kasalar
{
    partial class frmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAciklama = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAciklama = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaGiris = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaCikis = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBakiye = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colBakiye = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "funnel.png");
            this.ımageList1.Images.SetKeyName(2, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            this.ımageList1.Images.SetKeyName(4, "view.png");
            this.ımageList1.Images.SetKeyName(5, "Kasa_Hareket32x32.png");
            this.ımageList1.Images.SetKeyName(6, "Kasa_Karti32x32.png");
            this.ımageList1.Images.SetKeyName(7, "Kasa_Liste32x32.png");
            this.ımageList1.Images.SetKeyName(8, "Kapat24x24.png");
            this.ımageList1.Images.SetKeyName(9, "KasaHareket.png");
            this.ımageList1.Images.SetKeyName(10, "KasaSil.png");
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDuzenle.ImageOptions.ImageIndex = 7;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(92, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(89, 48);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnHareket);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 523);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(921, 73);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnHareket
            // 
            this.btnHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHareket.ImageOptions.ImageIndex = 5;
            this.btnHareket.ImageOptions.ImageList = this.ımageList1;
            this.btnHareket.Location = new System.Drawing.Point(274, 23);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(97, 48);
            this.btnHareket.TabIndex = 1;
            this.btnHareket.Text = "Kasa\r\nHareketleri";
            this.btnHareket.Click += new System.EventHandler(this.btnKasaHareketleri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 8;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(829, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.ImageOptions.ImageIndex = 4;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(468, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 48);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(371, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 48);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.ImageIndex = 10;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(181, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 48);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkle.ImageOptions.ImageIndex = 6;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(2, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 48);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.Kasa_Karti32x32;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(921, 53);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Kasa Kartları";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(921, 470);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 137;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(58, 20);
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.LayoutViewField = this.layoutViewField_colKasaKodu;
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colKasaKodu
            // 
            this.layoutViewField_colKasaKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaKodu.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colKasaKodu.Name = "layoutViewField_colKasaKodu";
            this.layoutViewField_colKasaKodu.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colKasaKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.LayoutViewField = this.layoutViewField_colKasaAdi;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colKasaAdi
            // 
            this.layoutViewField_colKasaAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaAdi.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colKasaAdi.Name = "layoutViewField_colKasaAdi";
            this.layoutViewField_colKasaAdi.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colKasaAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.LayoutViewField = this.layoutViewField_colYetkiliKodu;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colYetkiliKodu
            // 
            this.layoutViewField_colYetkiliKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliKodu.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colYetkiliKodu.Name = "layoutViewField_colYetkiliKodu";
            this.layoutViewField_colYetkiliKodu.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colYetkiliKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.LayoutViewField = this.layoutViewField_colYetkiliAdi;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colYetkiliAdi
            // 
            this.layoutViewField_colYetkiliAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliAdi.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colYetkiliAdi.Name = "layoutViewField_colYetkiliAdi";
            this.layoutViewField_colYetkiliAdi.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colYetkiliAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.LayoutViewField = this.layoutViewField_colAciklama;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colAciklama
            // 
            this.layoutViewField_colAciklama.EditorPreferredWidth = 137;
            this.layoutViewField_colAciklama.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colAciklama.Name = "layoutViewField_colAciklama";
            this.layoutViewField_colAciklama.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colAciklama.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.LayoutViewField = this.layoutViewField_colKasaGiris;
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colKasaGiris
            // 
            this.layoutViewField_colKasaGiris.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaGiris.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colKasaGiris.Name = "layoutViewField_colKasaGiris";
            this.layoutViewField_colKasaGiris.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colKasaGiris.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.LayoutViewField = this.layoutViewField_colKasaCikis;
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colKasaCikis
            // 
            this.layoutViewField_colKasaCikis.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaCikis.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colKasaCikis.Name = "layoutViewField_colKasaCikis";
            this.layoutViewField_colKasaCikis.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colKasaCikis.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.LayoutViewField = this.layoutViewField_colBakiye;
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            // 
            // layoutViewField_colBakiye
            // 
            this.layoutViewField_colBakiye.EditorPreferredWidth = 137;
            this.layoutViewField_colBakiye.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colBakiye.Name = "layoutViewField_colBakiye";
            this.layoutViewField_colBakiye.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colBakiye.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colKasaKodu,
            this.layoutViewField_colKasaAdi,
            this.layoutViewField_colYetkiliKodu,
            this.layoutViewField_colYetkiliAdi,
            this.layoutViewField_colAciklama,
            this.layoutViewField_colKasaGiris,
            this.layoutViewField_colKasaCikis,
            this.layoutViewField_colBakiye});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 596);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Kartları";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnHareket;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAciklama;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAciklama;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaGiris;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaGiris;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaCikis;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaCikis;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}