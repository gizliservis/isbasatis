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
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;

namespace IsbaSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        OdemeTuruDAL odemeTuruDAL = new OdemeTuruDAL();
        int secilen;
        public frmOdemeTuru()
        {
            InitializeComponent();
        }
        void listele()
        {
            gridcontOdemeTuru.DataSource = odemeTuruDAL.OdemeTuruListele(context);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void frmOdemeTuru_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeTuruDAL.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeTuruDAL.Save(context);
                listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(new Isbasatis.Entities.Tables.OdemeTuru());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
             secilen =Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu));
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(odemeTuruDAL.GetByFilter(context,c=>c.Id==secilen));
            form.ShowDialog();
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
            string secilenad = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruAdi).ToString();
            frmOdemeTuruHareketleri frm = new frmOdemeTuruHareketleri(secilen);
            frm.ShowDialog();
            listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}