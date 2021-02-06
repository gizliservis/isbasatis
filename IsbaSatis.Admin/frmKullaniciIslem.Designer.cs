namespace IsbaSatis.Admin
{
    partial class frmKullaniciIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciIslem));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupGenelBilgiler = new DevExpress.XtraEditors.GroupControl();
            this.txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.txtCevap = new DevExpress.XtraEditors.TextEdit();
            this.txtGorevi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtHatırlatma = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblCariAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGenelBilgiler)).BeginInit();
            this.groupGenelBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHatırlatma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.ImageOptions.Image = global::IsbaSatis.Admin.Properties.Resources.id_card;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(430, 59);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Kullanıcı Kartları";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 460);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(430, 76);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(335, 29);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 45);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(239, 29);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 45);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupGenelBilgiler
            // 
            this.groupGenelBilgiler.Controls.Add(this.txtParolaTekrar);
            this.groupGenelBilgiler.Controls.Add(this.txtCevap);
            this.groupGenelBilgiler.Controls.Add(this.txtGorevi);
            this.groupGenelBilgiler.Controls.Add(this.txtParola);
            this.groupGenelBilgiler.Controls.Add(this.txtHatırlatma);
            this.groupGenelBilgiler.Controls.Add(this.txtSoyadi);
            this.groupGenelBilgiler.Controls.Add(this.labelControl4);
            this.groupGenelBilgiler.Controls.Add(this.txtAdi);
            this.groupGenelBilgiler.Controls.Add(this.labelControl2);
            this.groupGenelBilgiler.Controls.Add(this.labelControl3);
            this.groupGenelBilgiler.Controls.Add(this.txtKullaniciAdi);
            this.groupGenelBilgiler.Controls.Add(this.labelControl1);
            this.groupGenelBilgiler.Controls.Add(this.labelControl8);
            this.groupGenelBilgiler.Controls.Add(this.labelControl7);
            this.groupGenelBilgiler.Controls.Add(this.lblCariAdi);
            this.groupGenelBilgiler.Controls.Add(this.lblCariKodu);
            this.groupGenelBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupGenelBilgiler.Location = new System.Drawing.Point(0, 59);
            this.groupGenelBilgiler.Name = "groupGenelBilgiler";
            this.groupGenelBilgiler.Size = new System.Drawing.Size(430, 237);
            this.groupGenelBilgiler.TabIndex = 10;
            this.groupGenelBilgiler.Text = "Genel Bilgiler";
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(115, 159);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Properties.PasswordChar = '*';
            this.txtParolaTekrar.Size = new System.Drawing.Size(306, 20);
            this.txtParolaTekrar.TabIndex = 2;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(115, 211);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(306, 20);
            this.txtCevap.TabIndex = 2;
            // 
            // txtGorevi
            // 
            this.txtGorevi.Location = new System.Drawing.Point(115, 107);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Size = new System.Drawing.Size(306, 20);
            this.txtGorevi.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(115, 133);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(306, 20);
            this.txtParola.TabIndex = 2;
            // 
            // txtHatırlatma
            // 
            this.txtHatırlatma.Location = new System.Drawing.Point(115, 185);
            this.txtHatırlatma.Name = "txtHatırlatma";
            this.txtHatırlatma.Size = new System.Drawing.Size(306, 20);
            this.txtHatırlatma.TabIndex = 2;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(115, 81);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(306, 20);
            this.txtSoyadi.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(2, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 15);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Parola Tekrar :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(115, 57);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(306, 20);
            this.txtAdi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(2, 213);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 15);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cevap :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(2, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 15);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Parola :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(115, 31);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(306, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(2, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hatırlatma Sorusu";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(2, 109);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 15);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Görevi :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(2, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 15);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Soyadı :";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Appearance.Options.UseTextOptions = true;
            this.lblCariAdi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCariAdi.AppearanceDisabled.Options.UseTextOptions = true;
            this.lblCariAdi.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCariAdi.AppearanceHovered.Options.UseTextOptions = true;
            this.lblCariAdi.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCariAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCariAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCariAdi.Location = new System.Drawing.Point(2, 60);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Size = new System.Drawing.Size(107, 15);
            this.lblCariAdi.TabIndex = 0;
            this.lblCariAdi.Text = "Adı :";
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.Appearance.Options.UseTextOptions = true;
            this.lblCariKodu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCariKodu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCariKodu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCariKodu.Location = new System.Drawing.Point(2, 33);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(107, 15);
            this.lblCariKodu.TabIndex = 0;
            this.lblCariKodu.Text = "Kullanıcı Adı :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeList1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 296);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 164);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Yetkiler";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 23);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Ana Menü",
            "FrmAnaMenu"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Stoklar",
            "btnStoklar"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Cariler",
            "btnCari"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Fatura Ve Fişler",
            "btnFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Stok Hareketleri",
            "btnStokHareketleri"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Kasa Hareketleri",
            "btnKasaHareketleri"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Satış Ekranı",
            "btnSatisEkrani"}, 0);
            this.treeList1.AppendNode(new object[] {
            "İndirimler",
            "btnIndirim"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Toplu Fİyat Değişikliği",
            "btnTopluFiyat"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Hızlı Satış Menüsü",
            "btnHizliSatis"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Personeller",
            "btnPersoneller"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Kasalar",
            "btnKasa"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Ödeme Türleri",
            "btnOdemeTur"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Depolar",
            "btnDepo"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Etiket Basım Sihirbazı",
            "btnEtiketBas"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Özgün Rapor Sihirbazı",
            "btnOzgunRapor"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Raporlar",
            "btnRapor"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Rapor Oluştur",
            "btnRaporOlustur"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Ajanda",
            "btnAjanda"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Sms",
            "btnSms"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Alış Faturası",
            "btnAlisFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Satış Faturası",
            "btnSatisFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Toptan Satış Faturası",
            "btnToptanSatisFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Alış İade Faturası",
            "btnAlisIadeFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Satış İade Faturası",
            "btnSatisIadeFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Tahsilat Fişi",
            "btnTahsilatFisFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Ödeme Fişi",
            "btnOdemeFisFatura"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Sayım Fazlası Fişi",
            "btnSayimfazlasi"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Sayım Eksiği Fişi",
            "btnSayımEksigi"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Cari Devir Fişi",
            "btnCariDevir"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Ayarlar",
            "btnAyar"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Güncelle",
            "btnGuncelle"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Stoklar",
            "frmStok"}, -1, 0, 0, 5);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 32, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 32, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 32, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Kopyala",
            "btnKopyala"}, 32);
            this.treeList1.AppendNode(new object[] {
            "Hareket Görüntüle",
            "btnHareket"}, 32, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "Cariler",
            "frmCari"}, -1, 0, 0, 4);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 38, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 38, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 38, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Kopyala",
            "btnKopyala"}, 38);
            this.treeList1.AppendNode(new object[] {
            "Hareket Görüntüle",
            "btnHareket"}, 38, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "Depolar",
            "frmDepo"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 44, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 44, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 44, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Hareket Görüntüle",
            "btnHareket"}, 44, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "Fişler",
            "frmFis"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 49, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 49, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 49, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Kasalar",
            "frmKasa"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 53, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 53, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 53, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Hareket Görüntüle",
            "btnHareket"}, 53, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "Ödeme Türleri",
            "frmOdemeTuru"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 58, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 58, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 58, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Hareket",
            "btnHareket"}, 58, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "Personeller",
            "frmPersonel"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 63, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 63, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 63, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Hareket",
            "btnHareket"}, 63, 0, 0, 6);
            this.treeList1.AppendNode(new object[] {
            "İndirimler",
            "frmIndirim"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Ekle",
            "btnEkle"}, 68, 0, 0, 0);
            this.treeList1.AppendNode(new object[] {
            "Düzenle",
            "btnDuzenle"}, 68, 0, 0, 1);
            this.treeList1.AppendNode(new object[] {
            "Sil",
            "btnSil"}, 68, 0, 0, 2);
            this.treeList1.AppendNode(new object[] {
            "Pasif Yap",
            "btnPasifYap"}, 68);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeList1.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.Size = new System.Drawing.Size(426, 139);
            this.treeList1.StateImageList = this.ımageList2;
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.ShowInCustomizationForm = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "add.png");
            this.ımageList2.Images.SetKeyName(1, "pencil.png");
            this.ımageList2.Images.SetKeyName(2, "delete.png");
            this.ımageList2.Images.SetKeyName(3, "refresh.png");
            this.ımageList2.Images.SetKeyName(4, "user.png");
            this.ımageList2.Images.SetKeyName(5, "package.png");
            this.ımageList2.Images.SetKeyName(6, "replace2.png");
            // 
            // frmKullaniciIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 536);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupGenelBilgiler);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.frmKullaniciIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGenelBilgiler)).EndInit();
            this.groupGenelBilgiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHatırlatma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupGenelBilgiler;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.TextEdit txtGorevi;
        private DevExpress.XtraEditors.TextEdit txtHatırlatma;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblCariAdi;
        private DevExpress.XtraEditors.LabelControl lblCariKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private System.Windows.Forms.ImageList ımageList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}