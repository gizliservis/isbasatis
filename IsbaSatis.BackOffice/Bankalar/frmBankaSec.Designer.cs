
namespace IsbaSatis.BackOffice.Bankalar
{
    partial class frmBankaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaSec));
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.btnBankaSec = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIbanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kaydet24x24.png");
            this.ımageList1.Images.SetKeyName(1, "Kapat24x24.png");
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.lblUyari);
            this.grpMenu.Controls.Add(this.btnBankaSec);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 440);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1066, 87);
            this.grpMenu.TabIndex = 8;
            this.grpMenu.Text = "Menü";
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
            // btnBankaSec
            // 
            this.btnBankaSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBankaSec.ImageOptions.ImageIndex = 0;
            this.btnBankaSec.ImageOptions.ImageList = this.ımageList1;
            this.btnBankaSec.Location = new System.Drawing.Point(884, 23);
            this.btnBankaSec.Name = "btnBankaSec";
            this.btnBankaSec.Size = new System.Drawing.Size(90, 62);
            this.btnBankaSec.TabIndex = 0;
            this.btnBankaSec.Text = "Seç";
            this.btnBankaSec.Click += new System.EventHandler(this.btnBankaSec_Click);
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
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1066, 56);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Banka Seçim Ekranı";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1066, 384);
            this.gridControl1.TabIndex = 7;
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
            this.colHesapKodu,
            this.colHesapIsmi,
            this.colBankasi,
            this.colSube,
            this.colIbanNo,
            this.colHesapNo});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(862, 400, 252, 266);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.Caption = "Hesap kodu";
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
            this.colIbanNo.Caption = "İbanNo";
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
            // frmBankaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 527);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBankaSec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl lblUyari;
        private DevExpress.XtraEditors.SimpleButton btnBankaSec;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn colBankasi;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colIbanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapNo;
    }
}