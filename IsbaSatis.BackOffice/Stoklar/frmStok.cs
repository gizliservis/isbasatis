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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Extensions.FluentValidation;
using Isbasatis.Entities.Data_Access;
using IsbaSatis.BackOffice.Stoklar;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Stok;
using System.IO;
using Isbasatis.Entities.Tools.LoadingTool;

namespace IsbaSatis.BackOffice.AnaMenü
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        readonly IsbaSatisContext context = new IsbaSatisContext();
        readonly StokDAL stokDAL = new StokDAL();
        private readonly ExportTool export;
        readonly string filename = "Stok.xml";
        readonly LoadingTool lt;
      public  bool silindi = false;

        int secilen;
        public frmStok()
        {
            InitializeComponent();
            lt = new LoadingTool(this);
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                
                gridView1.RestoreLayoutFromXml(filename);
                
            }
            RolTool.RolleriYukle(this);
            GetAll();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
          
           
        }
        private void GetAll()
        {
            lt.AnimasyonBaslat();
            gridControl1.DataSource = stokDAL.StokListele(context);
            lt.AnimasyonBitir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
         
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                foreach (var hrkt in context.StokHareketleri)
                {
                    if (hrkt.StokId == secilen)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        silindi = true;
                        return;
                    }
                  
                }
                if (!silindi)
                {
                    stokDAL.Delete(context, c => c.Id == secilen);
                    stokDAL.Save(context);
                    GetAll();
                }
             






            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Stok.frmStokIslem form = new Stok.frmStokIslem(new Isbasatis.Entities.Tables.Stok());
            form.ShowDialog();
            GetAll();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (gridView1.RowCount==0)
            {
                MessageBox.Show("Lütfen İşlem İçin Bir Stok Seçiniz");
                return;
            }
            else
            {
                frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
            }
            


        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            Isbasatis.Entities.Tables.Stok stokentity = new Isbasatis.Entities.Tables.Stok();
            
            stokentity = stokDAL.GetByFilter(context, c => c.Id == secilen);
            stokentity.Id =Convert.ToInt32("-1");
            stokentity.StokKodu = null;
            stokentity.Barkod = null;
            Stok.frmStokIslem form = new Stok.frmStokIslem(stokentity);
            form.ShowDialog();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (gridView1.RowCount!=0)
            {
                frmStokHareket frm = new frmStokHareket(secilen);
                frm.ShowDialog();
            }
           
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow == true)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void frmStok_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Stok.frmStokIslem form = new Stok.frmStokIslem(new Isbasatis.Entities.Tables.Stok());
                form.ShowDialog();
                GetAll();
            }
            if (e.KeyCode == Keys.F7)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                    foreach (var hrkt in context.StokHareketleri)
                    {
                        if (hrkt.StokId == secilen)
                        {
                            MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                            silindi = true;
                            return;
                        }
                      
                    }
                    if (!silindi)
                    {
                        stokDAL.Delete(context, c => c.Id == secilen);
                        stokDAL.Save(context);
                        GetAll();
                    }
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Isbasatis.Entities.Tables.Stok stokentity = new Isbasatis.Entities.Tables.Stok();
                stokentity = stokDAL.GetByFilter(context, c => c.Id == secilen);
                stokentity.Id = -1;
                stokentity.StokKodu = null;
                Stok.frmStokIslem form = new Stok.frmStokIslem(stokentity);
                form.ShowDialog();
            }
            if (e.KeyCode == Keys.F5)
            {
                GetAll();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (gridView1.OptionsView.ShowAutoFilterRow == true)
                {
                    gridView1.OptionsView.ShowAutoFilterRow = false;
                }
                else
                {
                    gridView1.OptionsView.ShowAutoFilterRow = true;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmExcellAktar frm = new frmExcellAktar();
            frm.ShowDialog();
            GetAll();
        }
    }
}