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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Extensions.FluentValidation;
using Isbasatis.Entities.Data_Access;
using IsbaSatis.BackOffice.Stoklar;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Stok;

namespace IsbaSatis.BackOffice.AnaMenü
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        StokDAL stokDAL = new StokDAL();

        int secilen;
        public frmStok()
        {
            InitializeComponent();


        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            RolTool.RolleriYukle(this);
            GetAll();
        }
        private void GetAll()
        {
            gridControl1.DataSource = stokDAL.StokListele(context);
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
                foreach (var hareket in context.StokHareketleri.Select(c => c.StokId == secilen).ToList())
                {
                    if (hareket)
                    {
                        MessageBox.Show("Bu Ürünün Hareketi Bulunmakta Fatura ve Fişlerden Siliniz");
                        return;
                    }
                    else
                    {
                        stokDAL.Delete(context, c => c.Id == secilen);
                        stokDAL.Save(context);
                        GetAll();
                    }

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
            frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();


        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            Isbasatis.Entities.Tables.Stok stokentity = new Isbasatis.Entities.Tables.Stok();
            stokentity = stokDAL.GetByFilter(context, c => c.Id == secilen);
            stokentity.Id = -1;
            stokentity.StokKodu = null;
            Stok.frmStokIslem form = new Stok.frmStokIslem(stokentity);
            form.ShowDialog();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

            frmStokHareket frm = new frmStokHareket(secilen);
            frm.ShowDialog();
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
    }
}