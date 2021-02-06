namespace IsbaSatis.BackOffice.Fiyat_Değiştir
{
    partial class frmTopluFiyatDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopluFiyatDegistir));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimYonü = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimYonü = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimYonü)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimMiktari)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.Kasa_Tahsilat32x32;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(507, 41);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Toplu Fiyat Değiştir";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 322);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(507, 77);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(412, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 45);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(316, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 45);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoDegistir,
            this.repoDegisimTuru,
            this.repoDegisimYonü,
            this.repoDegisimMiktari});
            this.gridControl1.Size = new System.Drawing.Size(507, 281);
            this.gridControl1.TabIndex = 5;
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
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonü,
            this.colDegeri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.OptionsColumn.AllowEdit = false;
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 0;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.Name = "colKolonAdi";
            this.colKolonAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değiştirilecek mi ?";
            this.colDegistir.ColumnEdit = this.repoDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 1;
            // 
            // repoDegistir
            // 
            this.repoDegistir.AutoHeight = false;
            this.repoDegistir.Name = "repoDegistir";
            this.repoDegistir.OffText = "Off";
            this.repoDegistir.OnText = "On";
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repoDegisimTuru;
            this.colDegisimTuru.FieldName = "DegisimTuru";
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 2;
            // 
            // repoDegisimTuru
            // 
            this.repoDegisimTuru.AutoHeight = false;
            this.repoDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimTuru.Items.AddRange(new object[] {
            "Yüzde",
            "Tutar"});
            this.repoDegisimTuru.Name = "repoDegisimTuru";
            this.repoDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimYonü
            // 
            this.colDegisimYonü.Caption = "Değişim Yönü";
            this.colDegisimYonü.ColumnEdit = this.repoDegisimYonü;
            this.colDegisimYonü.FieldName = "DegisimYonu";
            this.colDegisimYonü.Name = "colDegisimYonü";
            this.colDegisimYonü.Visible = true;
            this.colDegisimYonü.VisibleIndex = 3;
            // 
            // repoDegisimYonü
            // 
            this.repoDegisimYonü.AutoHeight = false;
            this.repoDegisimYonü.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimYonü.Items.AddRange(new object[] {
            "Arttır",
            "Azalt"});
            this.repoDegisimYonü.Name = "repoDegisimYonü";
            this.repoDegisimYonü.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Miktarı";
            this.colDegeri.ColumnEdit = this.repoDegisimMiktari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 4;
            // 
            // repoDegisimMiktari
            // 
            this.repoDegisimMiktari.AutoHeight = false;
            this.repoDegisimMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimMiktari.DisplayFormat.FormatString = "N2";
            this.repoDegisimMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoDegisimMiktari.Name = "repoDegisimMiktari";
            // 
            // frmTopluFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 399);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTopluFiyatDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTopluFiyatDegistir";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimYonü)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimMiktari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonü;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repoDegistir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoDegisimYonü;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repoDegisimMiktari;
    }
}