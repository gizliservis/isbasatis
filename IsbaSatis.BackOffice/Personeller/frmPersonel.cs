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
using IsbaSatis.BackOffice.Fişler;

namespace IsbaSatis.BackOffice.Personeller
{
    public partial class frmPersonel : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        PersonelDAL personelDAL = new PersonelDAL();
        int secilen;
        public frmPersonel()
        {
            InitializeComponent();
        }
        private void listele()
        {
            gridControl1.DataSource = personelDAL.PersonelListele(context);
        }
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var hrkt in context.fisler)
                {
                    if (hrkt.PlasiyerId == secilen)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        return;
                    }
                    else
                    {
                        personelDAL.Delete(context, c => c.Id == secilen);
                        personelDAL.Save(context);
                        listele();
                    }

                }
     
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPersonelIslem form = new frmPersonelIslem(new Isbasatis.Entities.Tables.Personel());
            form.ShowDialog();
          
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
          string  secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
            frmPersonelIslem form = new frmPersonelIslem(personelDAL.GetByFilter(context, c => c.PersonelKodu == secilen));
            form.ShowDialog();
        }

        private void btnCariHareketleri_Click(object sender, EventArgs e)
        {
           secilen =Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmPersonelHareket form = new frmPersonelHareket(secilen);
            form.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(null, "Hakediş Fişi");
            frm.ShowDialog();
        }
    }
}