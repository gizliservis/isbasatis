using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using IsbaSatis.BackOffice.AnaMenü;
using IsbaSatis.BackOffice.Cari;
using IsbaSatis.BackOffice.Kasalar;
using IsbaSatis.BackOffice.Depolar;
using IsbaSatis.BackOffice.Ödeme_Türü;
using IsbaSatis.BackOffice.Tanım;
using IsbaSatis.BackOffice.Fişler;
using IsbaSatis.BackOffice.Stok_Hareketleri;
using IsbaSatis.BackOffice.KasaHareketleri;
using IsbaSatis.BackOffice.Personeller;
using IsbaSatis.BackOffice.Fiyat_Değiştir;
using IsbaSatis.BackOffice.İndirim;
using IsbaSatis.Raporlar.Stok;
using IsbaSatis.BackOffice.Raporlar;
using IsbaSatis.Raporlar.Fatura_Ve_Fiş;
using IsbaSatis.BackOffice.ajanda;
using IsbaSatis.BackOffice.DovizKurları;
using IsbaSatis.BackOffice.Ayarlar;
using IsbaSatisBackup;
using IsbaSatis.Update;
using System.Diagnostics;
using System.Reflection;
using System.Net;
using IsbaSatis.BackOffice.Hızlı_Satış;
using IsbaSatis.Admin;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Kod;
using Isbasatis.LicenseManager.LicenseInformations;
using Isbasatis.LicenseManger.LicenseInformations.Manager;
using IsbaSatis.BackOffice.Bankalar;
using DevExpress.XtraReports.UI;
using IsbaSatis.BackOffice.Stoklar;

namespace IsbaSatis.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LicenseConfirmation confirm = new LicenseConfirmation();
        public Form1()
        {
            InitializeComponent();

       
            using (var context = new IsbaSatisContext())
            {
                context.Database.CreateIfNotExists();
                if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "yönetici"))
                {
                    context.Kullanicilar.Add(new Kullanici
                    {
                        KullaniciAdi = "yönetici",
                        Adi = "isba",
                        Soyadi = "Yazılım",
                        Parola = "2515",
                        KayitTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
            frmKullaniciGiris form = new frmKullaniciGiris();
            form.ShowDialog();
            barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı : {RolTool.KullaniciEntity.KullaniciAdi != null}";


        }
        frmStok stok;
        frmAnaMenuBilgi anaMenuBilgi;
        frmCari cari;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            RolTool.RolleriYukle(ribbonControl1);
            if (anaMenuBilgi == null || anaMenuBilgi.IsDisposed)
            {
                anaMenuBilgi = new frmAnaMenuBilgi();
                anaMenuBilgi.MdiParent = this;
                anaMenuBilgi.Show();
                
            }


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Stok))
            {

                if (stok == null || stok.IsDisposed)
                {
                    stok = new frmStok();
                    stok.MdiParent = this;
                    stok.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Cari))
            {
                if (cari == null || cari.IsDisposed)
                {
                    cari = new frmCari();
                    cari.MdiParent = this;
                    cari.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        frmStokHareketleri hareketleri;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.StokHareketleri))
            {

                if (hareketleri == null || hareketleri.IsDisposed)
                {
                    hareketleri = new frmStokHareketleri();
                    hareketleri.MdiParent = this;
                    hareketleri.Show();
                }


            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmKasa kasa;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Kasalar))
            {

                if (kasa == null || kasa.IsDisposed)
                {
                    kasa = new frmKasa();
                    kasa.MdiParent = this;
                    kasa.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmDepo depo;
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Depolar))
            {

                if (depo == null || depo.IsDisposed)
                {
                    depo = new frmDepo();
                    depo.MdiParent = this;
                    depo.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmOdemeTuru odeme;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.OdemeTurleri))
            {

                if (odeme == null || odeme.IsDisposed)
                {
                    odeme = new frmOdemeTuru();
                    odeme.MdiParent = this;
                    odeme.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmFis fis;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Fatura))
            {
                if (fis == null || fis.IsDisposed)
                {
                    fis = new frmFis();
                    fis.MdiParent = this;
                    fis.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmKasaHareketler ksHareket;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.KasaHareketleri))
            {
                if (ksHareket == null || ksHareket.IsDisposed)
                {
                    ksHareket = new frmKasaHareketler();
                    ksHareket.MdiParent = this;
                    ksHareket.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmPersonel personel;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Personeller))
            {
                if (personel == null || personel.IsDisposed)
                {
                    personel = new frmPersonel();
                    personel.MdiParent = this;
                    personel.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(null, e.Item.Caption);
            frm.ShowDialog();
        }
        frmTopluFiyat tfd;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.TopluFiyatDegisikligi))
            {
                if (tfd == null || tfd.IsDisposed)
                {
                    tfd = new frmTopluFiyat();
                    tfd.MdiParent = this;
                    tfd.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmIndirim indirim;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Indirimler))
            {
                if (indirim == null || indirim.IsDisposed)
                {
                    indirim = new frmIndirim();
                    indirim.MdiParent = this;
                    indirim.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.SatisEkrani))
            {
                Process.Start($"{Application.StartupPath}\\IsbaSatis.FrontOffice.exe");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }
        frmRaporListele rprliste;
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Raporlar))
            {
                if (rprliste == null || rprliste.IsDisposed)
                {
                    rprliste = new frmRaporListele();
                    rprliste.MdiParent = this;
                    rprliste.Show();
                }

            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.RaporOlustur))
            {
                frmRaporDuzenle frm = new frmRaporDuzenle(null);
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.EtiketBasımSihirbazi))
            {
                frmEtiketOlustur frm = new frmEtiketOlustur();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.OzgunRaporSihirbazi))
            {
                frmOzgunRaporHazirla frm = new frmOzgunRaporHazirla();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Ajanda))
            {
                frmAjanda frm = new frmAjanda();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.DovizKurlari))
            {
                frmDovizKurlari frm = new frmDovizKurlari();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Ayarlar))
            {
                frmAyarlar frm = new frmAyarlar();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Yedekleme))
            {
                frmStokHareketRaporu frm = new frmStokHareketRaporu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();
            string ProgramVersion = Assembly.Load("IsbaSatis.BackOffice").GetName().Version.ToString();
            string GuncelVersion = indir.DownloadString("https://drive.google.com/open?id=1VWeuMu9rONUU3j5py-PVeCWUIV4diHnj");
            if (ProgramVersion != GuncelVersion)
            {
                Process.Start($"{Application.StartupPath}\\IsbaSatis.Update.exe".Replace("\n", ""));
            }
            else
            {
                MessageBox.Show("Programınız Güncel.");
            }


        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.HizliSatisMenusu))
            {
                frmHızliSatis frm = new frmHızliSatis();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }

        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKodlar frm = new frmKodlar("");
            frm.ShowDialog();
        }

        private void btnSms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Sms))
            {
                MessageBox.Show("Bu Modül Henüz Hazır Değil");
            }
            else
            {
                MessageBox.Show("Bu Modül Henüz Hazır Değil");
            }
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        frmBanka banka;
        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banka == null || banka.IsDisposed)
            {
                banka = new frmBanka();
                banka.MdiParent = this;
                banka.Show();
            }

        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptFatura fatura = new rptFatura("dnmfis000036");
            ReportDesignTool designTool = new ReportDesignTool(fatura);
            designTool.ShowDesigner();

        }

        private void barbtnBankaİslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBankaIslemleri islem = new frmBankaIslemleri(null);
            islem.ShowDialog();
        }

        private void barButtonItem9_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEtiketBasim frm = new frmEtiketBasim();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
