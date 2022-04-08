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
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Context;
using IsbaSatis.BackOffice;
using IsbaSatis.BackOffice.Cari;

namespace IsbaSatis.BackOffice.Kasalar
{
    public partial class frmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL = new KasaDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        int secilen;
        public frmKasa()
        {
            InitializeComponent();
         
        }
        public void Guncelle()
        {
           gridControl1.DataSource= kasaDAL.KasaListele(context);
        }

    

        private void btnAra_Click(object sender, EventArgs e)
        {
            //if (gridView1.OptionsView.ShowAutoFilterRow == true)
            //{
            //    gridView1.OptionsView.ShowAutoFilterRow = false;
            //}
            //else
            //{
            //    gridView1.OptionsView.ShowAutoFilterRow = true;
            //}
        }

     

     

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKasaIslem frm = new frmKasaIslem(new Isbasatis.Entities.Tables.Kasa());
            frm.ShowDialog();
            Guncelle();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen =Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmKasaIslem form = new frmKasaIslem(kasaDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                foreach (var hrkt in context.KasaHareketleri)
                {
                    if (hrkt.KasaId == secilen)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        return;
                    }
                    else
                    {
                        kasaDAL.Delete(context, c => c.Id == secilen);
                        kasaDAL.Save(context);
                        Guncelle();
                    }

                }


                
               
            }
        }

        private void btnKasaHareketleri_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmKasaHareketleri frm = new frmKasaHareketleri(secilen);
            frm.ShowDialog();
            Guncelle();
        }
    }
}