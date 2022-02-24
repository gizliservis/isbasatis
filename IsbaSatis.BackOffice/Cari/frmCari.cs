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
        private ExportTool export;
        public frmCari()
        {
            InitializeComponent();
            RolTool.RolleriYukle(this);
            export = new ExportTool(this,gridView1,dropDownButton1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmCariIslem form = new frmCariIslem(new Isbasatis.Entities.Tables.Cari());
            form.ShowDialog();
            GetAll();
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
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                foreach (var hrkt in context.fisler)
                {
                    if (hrkt.CariId == secilen)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        return;
                    }
                    else
                    {
                        cariDAL.Delete(context, c => c.Id == secilen);
                        cariDAL.Save(context);
                        GetAll();
                    }

                }
       
       
              
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

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmCariIslem form = new frmCariIslem(new Isbasatis.Entities.Tables.Cari());
                form.ShowDialog();
                GetAll();
            }
            if (e.KeyCode == Keys.F7)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Cari.frmCariIslem form = new Cari.frmCariIslem(cariDAL.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
            }
            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz!", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                    foreach (var hrkt in context.fisler)
                    {
                        if (hrkt.CariId == secilen)
                        {
                            MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                            return;
                        }
                        else
                        {
                            cariDAL.Delete(context, c => c.Id == secilen);
                            cariDAL.Save(context);
                            GetAll();
                        }

                    }



                }
            }
            if (e.KeyCode == Keys.F4)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Isbasatis.Entities.Tables.Cari carientity = new Isbasatis.Entities.Tables.Cari();
                carientity = cariDAL.GetByFilter(context, c => c.Id == secilen);
                Cari.frmCariIslem form = new Cari.frmCariIslem(carientity, true);
                form.ShowDialog();
                GetAll();
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
    }
}