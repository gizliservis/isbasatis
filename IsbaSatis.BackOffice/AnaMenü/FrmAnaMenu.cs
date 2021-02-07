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
using Isbasatis.LicenseManager.Client;

namespace IsbaSatis.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LicenseConfirmation confirm = new LicenseConfirmation();
        public Form1()
        {
            InitializeComponent();
            using (var context=new IsbaSatisContext())
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
            barKullaniciAdi.Caption =$"Giriş Yapan Kullanıcı : {RolTool.KullaniciEntity.KullaniciAdi}" ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RolTool.RolleriYukle(ribbonControl1);
            frmAnaMenuBilgi frm = new frmAnaMenuBilgi();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Stok))
            {
                frmStok stok = new frmStok();
                stok.MdiParent = this;
                stok.Show();
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
                frmCari cari = new frmCari();
                cari.MdiParent = this;
                cari.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
               
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokHareketleri hareketleri = new frmStokHareketleri();
            hareketleri.MdiParent = this;
            hareketleri.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasa frm = new frmKasa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepo frm = new frmDepo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdemeTuru frm = new frmOdemeTuru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFis frm = new frmFis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaHareketler hareketler = new frmKasaHareketler();
            hareketler.MdiParent = this;
            hareketler.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPersonel personel = new frmPersonel();
            personel.MdiParent = this;
            personel.Show();
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(null, e.Item.Caption);
            frm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTopluFiyat frm = new frmTopluFiyat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIndirim frm = new frmIndirim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\IsbaSatis.FrontOffice.exe");
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmRaporListele frm = new frmRaporListele();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRaporDuzenle frm = new frmRaporDuzenle();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEtiketOlustur frm = new frmEtiketOlustur();
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOzgunRaporHazirla frm = new frmOzgunRaporHazirla();
            frm.ShowDialog();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAjanda frm = new frmAjanda();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDovizKurlari frm = new frmDovizKurlari();
            frm.ShowDialog();
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();
            string ProgramVersion = Assembly.Load("IsbaSatis.BackOffice").GetName().Version.ToString();
            string GuncelVersion = indir.DownloadString("https://drive.google.com/open?id=1VWeuMu9rONUU3j5py-PVeCWUIV4diHnj");
            if (ProgramVersion != GuncelVersion)
            {
                Process.Start($"{Application.StartupPath}\\IsbaSatis.Update.exe".Replace("\n",""));
            }
            else
            {
                MessageBox.Show("Programınız Güncel.");
            }


        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHızliSatis frm = new frmHızliSatis();
            frm.ShowDialog();
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKodlar frm = new frmKodlar("");
            frm.ShowDialog();
        }
    }
}
