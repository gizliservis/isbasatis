
namespace IsbaSatis.BackOffice.Bankalar
{
    partial class frmBankaKartlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaKartlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTelefonu = new DevExpress.XtraEditors.TextEdit();
            this.txtYetkiliAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.txtIbanNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtHesapKodu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIbanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKodu.Properties)).BeginInit();
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
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.BackOffice.Properties.Resources.Banka32x32;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(416, 41);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Banka Kart Tanımı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(225, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 45);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(321, 33);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 45);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Controls.Add(this.btnKaydet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 308);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(416, 83);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Menü";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(118, 59);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(294, 20);
            this.txtSube.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(5, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bankası :";
            // 
            // txtBankasi
            // 
            this.txtBankasi.Location = new System.Drawing.Point(118, 32);
            this.txtBankasi.Name = "txtBankasi";
            this.txtBankasi.Size = new System.Drawing.Size(294, 20);
            this.txtBankasi.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 15);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Şubesi :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTelefonu);
            this.groupControl2.Controls.Add(this.txtYetkiliAdi);
            this.groupControl2.Controls.Add(this.txtHesapNo);
            this.groupControl2.Controls.Add(this.txtIbanNo);
            this.groupControl2.Controls.Add(this.txtSube);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtBankasi);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 118);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(416, 190);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Diğer Bilgiler";
            // 
            // txtTelefonu
            // 
            this.txtTelefonu.Location = new System.Drawing.Point(117, 163);
            this.txtTelefonu.Name = "txtTelefonu";
            this.txtTelefonu.Size = new System.Drawing.Size(294, 20);
            this.txtTelefonu.TabIndex = 5;
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.Location = new System.Drawing.Point(117, 137);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(294, 20);
            this.txtYetkiliAdi.TabIndex = 5;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(117, 111);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(294, 20);
            this.txtHesapNo.TabIndex = 5;
            // 
            // txtIbanNo
            // 
            this.txtIbanNo.Location = new System.Drawing.Point(117, 85);
            this.txtIbanNo.Name = "txtIbanNo";
            this.txtIbanNo.Size = new System.Drawing.Size(294, 20);
            this.txtIbanNo.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(5, 168);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 15);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Yekili Telefonu :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(5, 142);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 15);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Yekili Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(5, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 15);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Hesap No :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(5, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 15);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Iban No :";
            // 
            // txtHesapIsmi
            // 
            this.txtHesapIsmi.Location = new System.Drawing.Point(118, 53);
            this.txtHesapIsmi.Name = "txtHesapIsmi";
            this.txtHesapIsmi.Size = new System.Drawing.Size(294, 20);
            this.txtHesapIsmi.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(5, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 15);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Banka Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Banka Kodu :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtHesapIsmi);
            this.groupControl1.Controls.Add(this.txtHesapKodu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(416, 77);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kasa Bilgisi";
            // 
            // txtHesapKodu
            // 
            this.txtHesapKodu.Location = new System.Drawing.Point(118, 26);
            this.txtHesapKodu.Name = "txtHesapKodu";
            this.txtHesapKodu.Size = new System.Drawing.Size(123, 20);
            this.txtHesapKodu.TabIndex = 6;
            // 
            // frmBankaKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 391);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaKartlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Kartları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIbanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBankasi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtHesapIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapKodu;
        private DevExpress.XtraEditors.TextEdit txtTelefonu;
        private DevExpress.XtraEditors.TextEdit txtYetkiliAdi;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.TextEdit txtIbanNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}