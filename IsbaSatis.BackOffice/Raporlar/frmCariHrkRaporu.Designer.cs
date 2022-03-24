
namespace IsbaSatis.BackOffice.Raporlar
{
    partial class frmCariHrkRaporu
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
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.lblArasinda = new DevExpress.XtraEditors.LabelControl();
            this.lblBitisTarihi = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslangicTarihi = new DevExpress.XtraEditors.LabelControl();
            this.BtnHazırla = new DevExpress.XtraEditors.SimpleButton();
            this.dateBitis = new DevExpress.XtraEditors.DateEdit();
            this.dateBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İnd T.";
            this.colIndirimTutari.DisplayFormat.FormatString = "C2";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.UnboundExpression = "[BirimFiyati] * [Miktar] * [IndirimOrani] / 100";
            this.colIndirimTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 9;
            this.colIndirimTutari.Width = 69;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 5;
            this.colDepoAdi.Width = 99;
            // 
            // colSatisToplam
            // 
            this.colSatisToplam.Caption = "Toplam T.";
            this.colSatisToplam.DisplayFormat.FormatString = "C2";
            this.colSatisToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisToplam.FieldName = "SatisToplam";
            this.colSatisToplam.Name = "colSatisToplam";
            this.colSatisToplam.OptionsColumn.AllowEdit = false;
            this.colSatisToplam.Visible = true;
            this.colSatisToplam.VisibleIndex = 12;
            this.colSatisToplam.Width = 93;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colSeriNo.Width = 79;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 10;
            this.colTarih.Width = 120;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.OptionsColumn.ShowInCustomizationForm = false;
            this.colSaat.Width = 55;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Width = 42;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colDepoKodu.Width = 68;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd O.";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Width = 47;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Controls.Add(this.lblArasinda);
            this.panelControl1.Controls.Add(this.lblBitisTarihi);
            this.panelControl1.Controls.Add(this.lblBaslangicTarihi);
            this.panelControl1.Controls.Add(this.BtnHazırla);
            this.panelControl1.Controls.Add(this.dateBitis);
            this.panelControl1.Controls.Add(this.dateBaslangic);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1229, 85);
            this.panelControl1.TabIndex = 6;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.Location = new System.Drawing.Point(1058, 36);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 7;
            this.dropDownButton1.Text = "Dışarı Çıkart";
            // 
            // lblArasinda
            // 
            this.lblArasinda.Location = new System.Drawing.Point(391, 46);
            this.lblArasinda.Name = "lblArasinda";
            this.lblArasinda.Size = new System.Drawing.Size(42, 13);
            this.lblArasinda.TabIndex = 4;
            this.lblArasinda.Text = "Arasında";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.Location = new System.Drawing.Point(486, 46);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(55, 13);
            this.lblBitisTarihi.TabIndex = 3;
            this.lblBitisTarihi.Text = "Bitis Tarihi :";
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(11, 46);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(80, 13);
            this.lblBaslangicTarihi.TabIndex = 3;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi :";
            // 
            // BtnHazırla
            // 
            this.BtnHazırla.Location = new System.Drawing.Point(794, 36);
            this.BtnHazırla.Name = "BtnHazırla";
            this.BtnHazırla.Size = new System.Drawing.Size(75, 33);
            this.BtnHazırla.TabIndex = 2;
            this.BtnHazırla.Text = "Hazırla";
            this.BtnHazırla.Click += new System.EventHandler(this.BtnHazırla_Click);
            // 
            // dateBitis
            // 
            this.dateBitis.EditValue = null;
            this.dateBitis.Location = new System.Drawing.Point(547, 43);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Size = new System.Drawing.Size(234, 20);
            this.dateBitis.TabIndex = 0;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.EditValue = null;
            this.dateBaslangic.Location = new System.Drawing.Point(107, 43);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Size = new System.Drawing.Size(234, 20);
            this.dateBaslangic.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 85);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1229, 349);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colIndirimTutari,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSatisToplam,
            this.colSeriNo,
            this.colTarih,
            this.colSaat,
            this.colAciklama,
            this.colIslemTuru});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(377, 159, 252, 266);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 115;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 2;
            this.colHareket.Width = 84;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 3;
            this.colStokKodu.Width = 208;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 351;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birim";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 6;
            this.colBirimi.Width = 80;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N3";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 7;
            this.colMiktar.Width = 71;
            // 
            // colKdv
            // 
            this.colKdv.Caption = "KDV(%)";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 8;
            this.colKdv.Width = 60;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim F.";
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 11;
            this.colBirimFiyati.Width = 72;
            // 
            // colIslemTuru
            // 
            this.colIslemTuru.Caption = " İşlem T.";
            this.colIslemTuru.FieldName = "IslemTuru";
            this.colIslemTuru.Name = "colIslemTuru";
            this.colIslemTuru.Visible = true;
            this.colIslemTuru.VisibleIndex = 1;
            this.colIslemTuru.Width = 128;
            // 
            // frmCariHrkRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 434);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCariHrkRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hareket Raporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.LabelControl lblArasinda;
        private DevExpress.XtraEditors.LabelControl lblBitisTarihi;
        private DevExpress.XtraEditors.LabelControl lblBaslangicTarihi;
        private DevExpress.XtraEditors.SimpleButton BtnHazırla;
        private DevExpress.XtraEditors.DateEdit dateBitis;
        private DevExpress.XtraEditors.DateEdit dateBaslangic;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTuru;
    }
}