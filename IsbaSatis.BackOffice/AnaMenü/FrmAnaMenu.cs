﻿using System;
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
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.StokHareketleri))
            {
                frmStokHareketleri hareketleri = new frmStokHareketleri();
                hareketleri.MdiParent = this;
                hareketleri.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
                
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Kasalar))
            {
                frmKasa frm = new frmKasa();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
               
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Depolar))
            {
                frmDepo frm = new frmDepo();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
             
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.OdemeTurleri))
            {
                frmOdemeTuru frm = new frmOdemeTuru();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
              
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Fatura))
            {
                frmFis frm = new frmFis();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
             
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.KasaHareketleri))
            {
                frmKasaHareketler hareketler = new frmKasaHareketler();
                hareketler.MdiParent = this;
                hareketler.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
             
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Personeller))
            {
                frmPersonel personel = new frmPersonel();
                personel.MdiParent = this;
                personel.Show();
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

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.TopluFiyatDegisikligi))
            {
                frmTopluFiyat frm = new frmTopluFiyat();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz Yetkili Kişiyle Görüşünüz");
            }
                
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Indirimler))
            {
                frmIndirim frm = new frmIndirim();
                frm.MdiParent = this;
                frm.Show();
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

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (confirm.ModuleConfirm(Isbasatis.LicenseManager.LicenseInformations.Enums.ModuleTypeEnum.Raporlar))
            {
                frmRaporListele frm = new frmRaporListele();
                frm.MdiParent = this;
                frm.Show();
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
                frmRaporDuzenle frm = new frmRaporDuzenle();
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
                frmBackup frm = new frmBackup();
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
                Process.Start($"{Application.StartupPath}\\IsbaSatis.Update.exe".Replace("\n",""));
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
    }
}
