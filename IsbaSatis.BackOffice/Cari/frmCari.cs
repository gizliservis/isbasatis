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
using Isbasatis.Entities.Tables.Other_Tables;
using Isbasatis.Entities.Tools;

namespace IsbaSatis.BackOffice.Cari
{
    public partial class frmCari : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        CariDAL cariDAL = new CariDAL();
        Nullable<int> secilen=null;
        public frmCari()
        {
            InitializeComponent();
            RolTool.RolleriYukle(this);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmCariIslem form = new frmCariIslem(new Isbasatis.Entities.Tables.Cari());
            form.ShowDialog();
            GetAll();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }
        public void GetAll()
        {
            gridControl1.DataSource = cariDAL.CariListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen =Convert.ToInt32( gridView1.GetFocusedRowCellValue(colId));
                cariDAL.Delete(context, c => c.Id == secilen);
                cariDAL.Save(context);
                GetAll();
              
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            Cari.frmCariIslem form = new Cari.frmCariIslem(cariDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            Isbasatis.Entities.Tables.Cari carientity = new Isbasatis.Entities.Tables.Cari();
            carientity = cariDAL.GetByFilter(context, c => c.Id == secilen);
            Cari.frmCariIslem form = new Cari.frmCariIslem(carientity,true);
            form.ShowDialog();
            GetAll();
        }

        private void btnCariHareketleri_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            string secilenad = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            frmCariHareket frm = new frmCariHareket(Convert.ToInt32( secilen));
            frm.ShowDialog();
            GetAll();
        }

        private void frmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}