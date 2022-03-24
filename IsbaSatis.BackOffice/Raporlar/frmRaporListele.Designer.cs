namespace IsbaSatis.BackOffice.Raporlar
{
    partial class frmRaporListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporListele));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.rptStokDurumu = new DevExpress.XtraNavBar.NavBarItem();
            this.rptStokBazli = new DevExpress.XtraNavBar.NavBarItem();
            this.rptStkBakiye = new DevExpress.XtraNavBar.NavBarItem();
            this.rptDepoBakiye = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.rptStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.rptGrupStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.rptStokBazliHareket = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.rptGunlukSatis = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblGenel = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtRaporAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRaporGrubu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrup = new DevExpress.XtraEditors.ButtonEdit();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).BeginInit();
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
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1070, 59);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Rapor Listesi";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "görüntüle.png");
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 465);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1070, 73);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(975, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 45);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 1;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(7, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 45);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.rptStokDurumu,
            this.rptStokBazli,
            this.rptStkBakiye,
            this.navBarItem4,
            this.rptStokHareketleri,
            this.rptGunlukSatis,
            this.rptGrupStokHareketleri,
            this.rptStokBazliHareket,
            this.navBarItem1,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.rptDepoBakiye,
            this.navBarItem13});
            this.navBarControl1.Location = new System.Drawing.Point(0, 59);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 238;
            this.navBarControl1.Size = new System.Drawing.Size(238, 406);
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok Raporları";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptStokDurumu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptStokBazli),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptStkBakiye),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptDepoBakiye)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // rptStokDurumu
            // 
            this.rptStokDurumu.Caption = "Stok Hareket Raporu";
            this.rptStokDurumu.Name = "rptStokDurumu";
            this.rptStokDurumu.Tag = "Bu Rapor Tüm Stok Hareketlerini Görebileceğiniz Rapordu";
            this.rptStokDurumu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptStokDurumu_LinkClicked);
            // 
            // rptStokBazli
            // 
            this.rptStokBazli.Caption = "Stok Bazlı Hareket Raporu";
            this.rptStokBazli.Name = "rptStokBazli";
            this.rptStokBazli.Tag = "Bu Rapor Bir Stok Seçilerek Hareketlerin Listelendiği Bir Rapordur";
            this.rptStokBazli.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptStokBazli_LinkClicked);
            // 
            // rptStkBakiye
            // 
            this.rptStkBakiye.Caption = "Stok Bakiye Raporu";
            this.rptStkBakiye.Name = "rptStkBakiye";
            this.rptStkBakiye.Tag = "Bu rapor tüm stokların bakiyelerinin listelendiği rapordur";
            this.rptStkBakiye.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptStkBakiye_LinkClicked);
            // 
            // rptDepoBakiye
            // 
            this.rptDepoBakiye.Caption = "Depo Bakiye Raporu";
            this.rptDepoBakiye.Name = "rptDepoBakiye";
            this.rptDepoBakiye.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptDepoBakiye_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari Raporları";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Genel Cari Bakiye Raporu";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.Tag = "Tüm Carilerin Bakiyelerini Gösterir";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Cari Hareket Raporu";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.Tag = "Bu raporda bir cari seçilerek o cariye ait yapılan hareketler listelenir";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked_1);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Cari Tahsilat ve Ödeme Bazlı Rapor";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Cari Ekstre Raporu";
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.Tag = "Cari ekstresi için alınan rapordur";
            this.navBarItem13.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem13_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Kasa Raporları";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptStokHareketleri),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptGrupStokHareketleri),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptStokBazliHareket)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // rptStokHareketleri
            // 
            this.rptStokHareketleri.Caption = "Kasa Bakiye Raporu";
            this.rptStokHareketleri.Name = "rptStokHareketleri";
            this.rptStokHareketleri.Tag = "Bu ropor tüm kasaların bakiyelerini gösterir";
            this.rptStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptStokHareketleri_LinkClicked);
            // 
            // rptGrupStokHareketleri
            // 
            this.rptGrupStokHareketleri.Caption = "Kasa Hareketler Raporu";
            this.rptGrupStokHareketleri.Name = "rptGrupStokHareketleri";
            this.rptGrupStokHareketleri.Tag = "Bu rapor Kasa işlemi seçilerek alınan bir rapordur";
            this.rptGrupStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptGrupStokHareketleri_LinkClicked);
            // 
            // rptStokBazliHareket
            // 
            this.rptStokBazliHareket.Caption = "Kasa Hareket Bazlı Rapor";
            this.rptStokBazliHareket.Name = "rptStokBazliHareket";
            this.rptStokBazliHareket.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptStokBazliHareket_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Finans Raporları";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.rptGunlukSatis),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // rptGunlukSatis
            // 
            this.rptGunlukSatis.Caption = "Satış Karlılık Raporu";
            this.rptGunlukSatis.Name = "rptGunlukSatis";
            this.rptGunlukSatis.Tag = "Bu rapor tarih aralığı kar/zarar raporudur";
            this.rptGunlukSatis.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.rptGunlukSatis_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Günlük Satış Raporu";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.Tag = "Bu rapor günlük rolarak satışları gösterem rapordur";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Ödeme Türü Bazlı Satış Raporu";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.Tag = "Bu rapor ödeme türü seçilerek listelenene rapordur ";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Banka Raporları";
            this.navBarGroup5.Expanded = true;
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Banka Hesabı Bakiye Raporu";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.Tag = "Bu rapor banka kartlarının bakiyesini görüntüler";
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Banka Hareket Raporu";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.Tag = "Bu rapor banka hareketlerini raporlar";
            this.navBarItem9.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem9_LinkClicked);
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Banka Kart Bazlı Hareket Raporu";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.Tag = "Bu rapor seçilen bir banka hesabının hareket raporunu görüntüler";
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem10_LinkClicked);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Banka İşlem Bazlı Hareket Raporu";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.Tag = "bu rapor banka hesaplarıyla yapılan havale eft  vb. işlemlerden birini seçerek gö" +
    "sterilen rapordur";
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblGenel);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Controls.Add(this.txtRaporAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtRaporGrubu);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl20);
            this.groupControl1.Controls.Add(this.txtGrup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(238, 59);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(832, 166);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Rapor Bilgileri";
            // 
            // lblGenel
            // 
            this.lblGenel.Location = new System.Drawing.Point(624, 116);
            this.lblGenel.Name = "lblGenel";
            this.lblGenel.Size = new System.Drawing.Size(63, 13);
            this.lblGenel.TabIndex = 13;
            this.lblGenel.Text = "labelControl3";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(119, 77);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(489, 80);
            this.txtAciklama.TabIndex = 9;
            // 
            // txtRaporAdi
            // 
            this.txtRaporAdi.Location = new System.Drawing.Point(119, 26);
            this.txtRaporAdi.Name = "txtRaporAdi";
            this.txtRaporAdi.Properties.ReadOnly = true;
            this.txtRaporAdi.Size = new System.Drawing.Size(489, 20);
            this.txtRaporAdi.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(6, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 15);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Rapor Adı :";
            // 
            // txtRaporGrubu
            // 
            this.txtRaporGrubu.Location = new System.Drawing.Point(119, 51);
            this.txtRaporGrubu.Name = "txtRaporGrubu";
            this.txtRaporGrubu.Properties.ReadOnly = true;
            this.txtRaporGrubu.Size = new System.Drawing.Size(489, 20);
            this.txtRaporGrubu.TabIndex = 8;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(6, 53);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(109, 15);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Rapor Grubu :";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Options.UseTextOptions = true;
            this.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl20.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl20.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl20.Location = new System.Drawing.Point(8, 77);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(107, 80);
            this.labelControl20.TabIndex = 7;
            this.labelControl20.Text = "Açıklama :";
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(624, 135);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGrup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtGrup.Size = new System.Drawing.Size(200, 20);
            this.txtGrup.TabIndex = 11;
            this.txtGrup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtGrup_ButtonClick);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(238, 225);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(832, 240);
            this.filterControl1.TabIndex = 8;
            this.filterControl1.Text = "filterControl1";
            // 
            // frmRaporListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 538);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRaporListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem rptStokDurumu;
        private DevExpress.XtraNavBar.NavBarItem rptStokBazli;
        private DevExpress.XtraNavBar.NavBarItem rptStkBakiye;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem rptStokHareketleri;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtRaporAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRaporGrubu;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem rptGunlukSatis;
        private DevExpress.XtraEditors.ButtonEdit txtGrup;
        private DevExpress.XtraEditors.LabelControl lblGenel;
        private DevExpress.XtraNavBar.NavBarItem rptGrupStokHareketleri;
        private DevExpress.XtraNavBar.NavBarItem rptStokBazliHareket;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem rptDepoBakiye;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
    }
}