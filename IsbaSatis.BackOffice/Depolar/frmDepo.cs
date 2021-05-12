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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tools;

namespace IsbaSatis.BackOffice.Depolar
{
    public partial class frmDepo : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        private int Secilen;

        public frmDepo()
        {
            InitializeComponent();
            RolTool.RolleriYukle(this);
        }

        private void frmDepo_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            gridcontDepo.DataSource = depoDAL.GetAll(context);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridDepo.OptionsView.ShowAutoFilterRow == true)
            {
                gridDepo.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridDepo.OptionsView.ShowAutoFilterRow = true;
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));
              

                foreach (var hrkt in context.StokHareketleri)
                {
                    if (hrkt.DepoId == Secilen)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        return;
                    }
                    else
                    {
                        depoDAL.Delete(context, c => c.Id == Secilen);
                        depoDAL.Save(context);
                        listele();
                    }

                }

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmDepoIslem form = new frmDepoIslem(new Depo());
            form.ShowDialog();
            listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));
            frmDepoIslem form = new frmDepoIslem(depoDAL.GetByFilter(context, c => c.Id == Secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {
            Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));

            frmDepoHareket frm = new frmDepoHareket(Secilen);
            frm.ShowDialog();
            listele();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDepoIslem form = new frmDepoIslem(new Depo());
            form.ShowDialog();
            listele();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));
            frmDepoIslem form = new frmDepoIslem(depoDAL.GetByFilter(context, c => c.Id == Secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));
                depoDAL.Delete(context, c => c.Id == Secilen);
                depoDAL.Save(context);
                listele();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void depoHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secilen = Convert.ToInt32(gridDepo.GetFocusedRowCellValue(colId));

            frmDepoHareket frm = new frmDepoHareket(Secilen);
            frm.ShowDialog();
            listele();
        }
    }
}