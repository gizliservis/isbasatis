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

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRaporListele : DevExpress.XtraEditors.XtraForm
    {
        rptStokHareketleri rapor;
        rptGunlukSatis gunlukSatis;
        rptGrupStokHareketleri rptGrupStok;
        rptSokBazliHareket rptSokBazli;
        rptStokDurumu stokDurumu;
        public frmRaporListele()
        {
            InitializeComponent();
            dateBaslangic.Visible = false;
            dateBitis.Visible = false;
            lblBaslangic.Visible = false;
            lblBitis.Visible = false;
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }
        private void rptStokHareketleri_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            dateBaslangic.Visible = true;
            dateBitis.Visible = true;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            lblBaslangic.Visible = true;
            lblBitis.Visible = true;

            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtRaporAdi.Text == "Hareket Raporu Tarih Aralığı")
            {
                rapor = new rptStokHareketleri(dateBaslangic.DateTime, dateBitis.DateTime);
                frmRaporGoruntule form = new frmRaporGoruntule(rapor);
                rapor.FilterString = filterControl1.FilterString;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else if (txtRaporAdi.Text == "Satış Raporu Günlük")
            {
                gunlukSatis = new rptGunlukSatis(dateBaslangic.DateTime);
                frmRaporGoruntule form = new frmRaporGoruntule(gunlukSatis);
                gunlukSatis.FilterString = filterControl1.FilterString;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else if (txtRaporAdi.Text == "Grup Bazlı Hareketler")
            {
                rptGrupStok = new rptGrupStokHareketleri(dateBaslangic.DateTime, dateBitis.DateTime, txtGrup.Text);
                frmRaporGoruntule form = new frmRaporGoruntule(rptGrupStok);
                form.WindowState = FormWindowState.Maximized;
                form.Show();

            }
            else if (txtRaporAdi.Text == "Stok Bazlı Hareketler")
            {
                rptSokBazli = new rptSokBazliHareket(dateBaslangic.DateTime, dateBitis.DateTime, txtGrup.Text);
                frmRaporGoruntule form = new frmRaporGoruntule(rptSokBazli);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else if (txtRaporAdi.Text== "Genel Stok Bakiye Durum Raporu")
            {
                stokDurumu = new rptStokDurumu();
                frmRaporGoruntule form = new frmRaporGoruntule(stokDurumu);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                MessageBox.Show("Helal Keke");
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
            dateBaslangic.Visible = true;
            dateBitis.Visible = false;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            lblBaslangic.Visible = true;
            lblBitis.Visible = false;
            txtGrup.Visible = false;
            lblGenel.Visible = false;
        }

        private void txtGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtRaporAdi.Text == "Grup Bazlı Hareketler")
            {
                switch (e.Button.Index)
                {
                    case 0:
                        frmTanim form = new frmTanim(frmTanim.TanimTuru.StokGrubu);
                        form.ShowDialog();
                        if (form.secildi == true)
                        {
                            txtGrup.Text = form._entity.Tanimi;
                        }
                        break;
                    case 1:
                        txtGrup.Text = null;
                        break;
                }
            }
            if (txtRaporAdi.Text == "Stok Bazlı Hareketler")
            {
                frmStokSec frm = new frmStokSec();
                frm.ShowDialog();
                if (frm.secildi)
                {
                    Isbasatis.Entities.Tables.Stok entity = frm.secilen.FirstOrDefault();
                    txtGrup.Text = entity.StokAdi;
                }

            }

        }

        private void rptGrupStokHareketleri_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            dateBaslangic.Visible = true;
            dateBitis.Visible = true;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            lblBaslangic.Visible = true;
            lblBitis.Visible = true;
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Stok Grubu";
        }

        private void rptStokBazliHareket_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            dateBaslangic.Visible = true;
            dateBitis.Visible = true;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            lblBaslangic.Visible = true;
            lblBitis.Visible = true;
            txtGrup.Visible = true;
            lblGenel.Visible = true;
            lblGenel.Text = "Stok İsmi";
        }

        private void rptStokDurumu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            dateBaslangic.Visible = false;
            dateBitis.Visible = false;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            lblBaslangic.Visible = true;
            lblBitis.Visible = false;
            txtGrup.Visible = false;
            lblGenel.Visible = false;


        }
    }
}