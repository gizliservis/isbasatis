
namespace IsbaSatis.BackOffice.Raporlar
{
    partial class frmBankaBakiyeRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaBakiyeRpt));
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.gridControlBanka = new DevExpress.XtraGrid.GridControl();
            this.gridBanka = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIbanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBanka)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.Location = new System.Drawing.Point(706, 13);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 11;
            this.dropDownButton1.Text = "Dışarı Çıkart";
            // 
            // gridControlBanka
            // 
            this.gridControlBanka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBanka.Location = new System.Drawing.Point(0, 41);
            this.gridControlBanka.MainView = this.gridBanka;
            this.gridControlBanka.Name = "gridControlBanka";
            this.gridControlBanka.Size = new System.Drawing.Size(845, 423);
            this.gridControlBanka.TabIndex = 10;
            this.gridControlBanka.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBanka});
            // 
            // gridBanka
            // 
            this.gridBanka.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridBanka.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridBanka.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridBanka.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridBanka.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colHesapKodu,
            this.colHesapIsmi,
            this.colBankasi,
            this.colSube,
            this.colIbanNo,
            this.colHesapNo,
            this.colYetkiliAdi,
            this.colYetkiliTelefonu,
            this.colBankaGiris,
            this.colBankaCikis,
            this.colBakiye});
            this.gridBanka.GridControl = this.gridControlBanka;
            this.gridBanka.Name = "gridBanka";
            this.gridBanka.OptionsView.ShowAutoFilterRow = true;
            this.gridBanka.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.Caption = "Hesap Kodu";
            this.colHesapKodu.FieldName = "HesapKodu";
            this.colHesapKodu.Name = "colHesapKodu";
            this.colHesapKodu.OptionsColumn.AllowEdit = false;
            this.colHesapKodu.Visible = true;
            this.colHesapKodu.VisibleIndex = 0;
            // 
            // colHesapIsmi
            // 
            this.colHesapIsmi.Caption = "Hesap İsmi";
            this.colHesapIsmi.FieldName = "HesapIsmi";
            this.colHesapIsmi.Name = "colHesapIsmi";
            this.colHesapIsmi.OptionsColumn.AllowEdit = false;
            this.colHesapIsmi.Visible = true;
            this.colHesapIsmi.VisibleIndex = 1;
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
            this.colSube.VisibleIndex = 3;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "İban No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.Visible = true;
            this.colIbanNo.VisibleIndex = 4;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.Visible = true;
            this.colHesapNo.VisibleIndex = 5;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            // 
            // colYetkiliTelefonu
            // 
            this.colYetkiliTelefonu.Caption = "Yetkili Tel No";
            this.colYetkiliTelefonu.FieldName = "YetkiliTelefonu";
            this.colYetkiliTelefonu.Name = "colYetkiliTelefonu";
            this.colYetkiliTelefonu.OptionsColumn.AllowEdit = false;
            // 
            // colBankaGiris
            // 
            this.colBankaGiris.Caption = "Banka Girişi";
            this.colBankaGiris.DisplayFormat.FormatString = "C2";
            this.colBankaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBankaGiris.FieldName = "BankaGiris";
            this.colBankaGiris.Name = "colBankaGiris";
            this.colBankaGiris.OptionsColumn.AllowEdit = false;
            this.colBankaGiris.Visible = true;
            this.colBankaGiris.VisibleIndex = 6;
            // 
            // colBankaCikis
            // 
            this.colBankaCikis.Caption = "Baka Çıkışı";
            this.colBankaCikis.DisplayFormat.FormatString = "C2";
            this.colBankaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBankaCikis.FieldName = "BankaCikis";
            this.colBankaCikis.Name = "colBankaCikis";
            this.colBankaCikis.OptionsColumn.AllowEdit = false;
            this.colBankaCikis.Visible = true;
            this.colBankaCikis.VisibleIndex = 7;
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
            this.colBakiye.VisibleIndex = 8;
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
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(845, 41);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Banka Kartları";
            // 
            // frmBankaBakiyeRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 464);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.gridControlBanka);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBankaBakiyeRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Bakiye Raporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBanka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraGrid.GridControl gridControlBanka;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBanka;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn colBankasi;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colIbanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapNo;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colBankaGiris;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colBankaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}