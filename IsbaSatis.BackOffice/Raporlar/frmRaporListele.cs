using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IsbaSatis.Raporlar.Stok;
using System.Reflection;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using IsbaSatis.Raporlar.Satis;
using IsbaSatis.BackOffice.Tanım;
using IsbaSatis.BackOffice.Stoklar;
using IsbaSatis.BackOffice.Cari;
using IsbaSatis.BackOffice.Stok_Hareketleri;
using IsbaSatis.BackOffice.KasaHareketleri;
using IsbaSatis.BackOffice.Kasalar;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRaporListele : DevExpress.XtraEditors.XtraForm
    {
        int stokId;
        int cariId;
        int kasaId;
        public frmRaporListele()
        {
            InitializeComponent();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }
        private void rptStokHareketleri_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtRaporAdi.Text == "Satış Karlılık Raporu")
            {
                frmStokHareketRaporu frm = new frmStokHareketRaporu();
                frm.ShowDialog();
                //rapor = new rptStokHareketleri(dateBaslangic.DateTime, dateBitis.DateTime);
                //frmRaporGoruntule form = new frmRaporGoruntule(rapor);
                //rapor.FilterString = filterControl1.FilterString;
                //form.WindowState = FormWindowState.Maximized;
                //form.Show();
            }
            else if (txtRaporAdi.Text == "Günlük Satış Raporu")
            {
                frmSatisRaporu frm = new frmSatisRaporu();
                frm.ShowDialog();
                //rapor = new rptStokHareketleri(dateBaslangic.DateTime, dateBitis.DateTime);
                //frmRaporGoruntule form = new frmRaporGoruntule(rapor);
                //rapor.FilterString = filterControl1.FilterString;
                //form.WindowState = FormWindowState.Maximized;
                //form.Show();
            }
            else if (txtRaporAdi.Text == "Stok Hareket Raporu")
            {
                frmStokHareketleri frm = new frmStokHareketleri();
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Stok Bakiye Raporu")
            {
                frmStokBakiyeRaporu frm = new frmStokBakiyeRaporu();
                frm.ShowDialog();
                //rptGrupStok = new rptGrupStokHareketleri(dateBaslangic.DateTime, dateBitis.DateTime, txtGrup.Text);
                //frmRaporGoruntule form = new frmRaporGoruntule(rptGrupStok);
                //form.WindowState = FormWindowState.Maximized;
                //form.Show();

            }
            else if (txtRaporAdi.Text == "Stok Bazlı Hareket Raporu")
            {
                frmStokBazliHrk frm = new frmStokBazliHrk(stokId);
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Genel Cari Bakiye Raporu")
            {
                frmCariBakiyeRaporu frm = new frmCariBakiyeRaporu();
                frm.ShowDialog();

                //stokDurumu = new rptStokDurumu();
                //frmRaporGoruntule form = new frmRaporGoruntule(stokDurumu);
                //form.WindowState = FormWindowState.Maximized;
                //form.Show();
            }
            else if (txtRaporAdi.Text == "Cari Hareket Raporu")
            {
                frmCariHrkRaporu frm = new frmCariHrkRaporu(cariId);
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Cari Tahsilat ve Ödeme Bazlı Rapor")
            {
                frmCariOdemeTahsilat frm = new frmCariOdemeTahsilat(cariId);
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Cari Ekstre Raporu")
            {
                frmCariEkstre frm = new frmCariEkstre(cariId);
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Kasa Bakiye Raporu")
            {
                frmKasaBakiyeRaporu frm = new frmKasaBakiyeRaporu();
                frm.ShowDialog();
            }  
            else if (txtRaporAdi.Text == "Kasa Hareketler Raporu")
            {
                frmKasaHareketler frm = new frmKasaHareketler(txtRaporAdi.Text,null);
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Kasa Bazlı Hareket Raporu")
            {
                frmKasaHareketler frm = new frmKasaHareketler(txtRaporAdi.Text,kasaId);
                frm.ShowDialog();
            } 
            else if (txtRaporAdi.Text == "Banka Hesabı Bakiye Raporu")
            {
                frmBankaBakiyeRpt frm = new frmBankaBakiyeRpt();
                frm.ShowDialog();
            }
            else if (txtRaporAdi.Text == "Banka Hareket Raporu")
            {
                frmBankaHareketRaporu frm = new frmBankaHareketRaporu();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Seçim Yapın");
            }


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rptGunlukSatis_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void txtGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtRaporAdi.Text.Contains("Cari"))
            {
                frmCariSec cariFrm = new frmCariSec();
                cariFrm.ShowDialog();
                if (cariFrm.secildi)
                {
                    Isbasatis.Entities.Tables.Cari cari = cariFrm.secilen.FirstOrDefault();
                    txtGrup.Text = cari.CariAdi;
                    cariId = cari.Id;
                }
            }
            if (txtRaporAdi.Text.Contains("Stok"))
            {
                frmStokSec frm = new frmStokSec();
                frm.ShowDialog();
                if (frm.secildi)
                {
                    Isbasatis.Entities.Tables.Stok entity = frm.secilen.FirstOrDefault();
                    txtGrup.Text = entity.StokAdi;
                    stokId = entity.Id;
                }

            }
            if (txtRaporAdi.Text.Contains("Kasa"))
            {
                frmKasaSec form = new frmKasaSec();
                form.ShowDialog();
                if (form.secildi)
                {
                    Isbasatis.Entities.Tables.Kasa entity = form.secilen.FirstOrDefault();
                    txtGrup.Text = entity.KasaAdi;
                    kasaId = entity.Id;

                }
            }

        }

        private void rptGrupStokHareketleri_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
            
        }

        private void rptStokBazliHareket_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Kasa Seç";
        }

        private void rptStokDurumu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
            lblGenel.Text = "Stok İsmi";


        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem5_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Cari Adı";

        }

        private void navBarItem13_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Cari Adı";
        }

        private void navBarItem6_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem7_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();

            lblGenel.Visible = false;
        }

        private void navBarItem8_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem9_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem10_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem11_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem4_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void navBarItem1_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Cari Adı";
        }

        private void rptDepoBakiye_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void rptStkBakiye_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void rptStokBazli_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Stok İsmi";
        }

       

        private void navBarItem2_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }
    }
}