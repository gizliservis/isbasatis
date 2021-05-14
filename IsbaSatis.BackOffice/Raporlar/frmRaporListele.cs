﻿using System;
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

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRaporListele : DevExpress.XtraEditors.XtraForm
    {
        rptStokHareketleri rapor;
        rptGunlukSatis gunlukSatis;
        rptGrupStokHareketleri rptGrupStok;
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

        private void navBarLink_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {




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
            if (txtRaporAdi.Text== "Grup Bazlı Hareketler")
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
        }
    }
}