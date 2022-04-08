
namespace IsbaSatis.BackOffice.Raporlar
{
    partial class frmBankaHareketRaporu
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
            this.colHesapIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIbanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.lblArasinda = new DevExpress.XtraEditors.LabelControl();
            this.lblBitisTarihi = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslangicTarihi = new DevExpress.XtraEditors.LabelControl();
            this.BtnHazırla = new DevExpress.XtraEditors.SimpleButton();
            this.dateBitis = new DevExpress.XtraEditors.DateEdit();
            this.dateBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colHesapIsmi
            // 
            this.colHesapIsmi.Caption = "HesapIsmi";
            this.colHesapIsmi.FieldName = "HesapIsmi";
            this.colHesapIsmi.Name = "colHesapIsmi";
            this.colHesapIsmi.Visible = true;
            this.colHesapIsmi.VisibleIndex = 3;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "Personel.PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "Personel.PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 7;
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
            this.colTarih.VisibleIndex = 8;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Car Kodu";
            this.colCariKodu.FieldName = "Cari.CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            // 
            // colPersonel
            // 
            this.colPersonel.FieldName = "Personel";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.OptionsColumn.AllowEdit = false;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "Cari.CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "HesapNo";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            // 
            // colBorc
            // 
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.OptionsColumn.AllowEdit = false;
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 10;
            // 
            // colAlacak
            // 
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.OptionsColumn.AllowEdit = false;
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 9;
            // 
            // colBankasi
            // 
            this.colBankasi.Caption = "Bankası";
            this.colBankasi.FieldName = "Bankasi";
            this.colBankasi.Name = "colBankasi";
            this.colBankasi.OptionsColumn.AllowEdit = false;
            this.colBankasi.Visible = true;
            this.colBankasi.VisibleIndex = 2;
            // 
            // colSube
            // 
            this.colSube.Caption = "Şube";
            this.colSube.FieldName = "Sube";
            this.colSube.Name = "colSube";
            this.colSube.OptionsColumn.AllowEdit = false;
            this.colSube.Visible = true;
            this.colSube.VisibleIndex = 6;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "İban No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colIbanNo.Visible = true;
            this.colIbanNo.VisibleIndex = 4;
            // 
            // colCariId
            // 
            this.colCariId.FieldName = "CariId";
            this.colCariId.Name = "colCariId";
            this.colCariId.OptionsColumn.AllowEdit = false;
            this.colCariId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            // 
            // colCariTuru
            // 
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.OptionsColumn.AllowEdit = false;
            // 
            // colFisTuru
            // 
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariTuru,
            this.colBelgeNo,
            this.colCariId,
            this.colIbanNo,
            this.colSube,
            this.colBankasi,
            this.colAlacak,
            this.colBorc,
            this.colToplamTutar,
            this.colHesapNo,
            this.colCariAdi,
            this.colPersonel,
            this.colCariKodu,
            this.colTarih,
            this.colPersonelAdi,
            this.colPersonelKodu,
            this.colHesapKodu,
            this.colHesapIsmi});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(799, 177, 252, 266);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.Caption = "HesapKodu";
            this.colHesapKodu.FieldName = "HesapKodu";
            this.colHesapKodu.Name = "colHesapKodu";
            this.colHesapKodu.UnboundExpression = "[Alacak] - [Borc]";
            this.colHesapKodu.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colHesapKodu.Visible = true;
            this.colHesapKodu.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Sayfa {0} of {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1017, 419);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.Location = new System.Drawing.Point(877, 41);
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
            this.panelControl1.Size = new System.Drawing.Size(1017, 79);
            this.panelControl1.TabIndex = 15;
            // 
            // frmBankaHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 498);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBankaHareketRaporu";
            this.Text = "frmBankaHareketRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colHesapIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapNo;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colBankasi;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colIbanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCariId;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.LabelControl lblArasinda;
        private DevExpress.XtraEditors.LabelControl lblBitisTarihi;
        private DevExpress.XtraEditors.LabelControl lblBaslangicTarihi;
        private DevExpress.XtraEditors.SimpleButton BtnHazırla;
        private DevExpress.XtraEditors.DateEdit dateBitis;
        private DevExpress.XtraEditors.DateEdit dateBaslangic;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}