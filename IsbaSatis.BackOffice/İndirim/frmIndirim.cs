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

namespace IsbaSatis.BackOffice.İndirim
{
    public partial class frmIndirim : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        IndirimDAL indirimDAL = new IndirimDAL();
        public frmIndirim()
        {
            InitializeComponent();
            listele();
        }
        private void listele()
        {

            gridContIndirim.DataSource = indirimDAL.IndirimListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmIndirimIslem frm = new frmIndirimIslem();
            frm.ShowDialog();
            listele();
        }

        private void frmIndirim_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilen = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimDAL.Delete(context, c => c.StokKodu == secilen);
                indirimDAL.Save(context);
                listele();
            }
        }



        private void btnDurum_Click(object sender, EventArgs e)
        {
            var secilenStokKodu = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilen = indirimDAL.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {

                secilen.Durumu = false;

                btnPasifYap.Text = "Pasif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, false);
                btnPasifYap.ImageOptions.ImageIndex = 7;
                indirimDAL.Save(context);
                listele();

            }
            else
            {
                secilen.Durumu = true;
                btnPasifYap.Text = "Aktif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, true);
                btnPasifYap.ImageOptions.ImageIndex = 6;
                indirimDAL.Save(context);
                listele();
            }

        }

        private void gridIndirim_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
                btnPasifYap.Text = "Pasif Yap";
                btnPasifYap.ImageOptions.ImageIndex = 7;
            }
            else
            {
                btnPasifYap.Text = "Aktif Yap";
                btnPasifYap.ImageOptions.ImageIndex = 6;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridIndirim.OptionsView.ShowAutoFilterRow = true ? gridIndirim.OptionsView.ShowAutoFilterRow == false : gridIndirim.OptionsView.ShowAutoFilterRow = true;
        }
    }
}