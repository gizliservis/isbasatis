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
using DevExpress.XtraReports.UI;
using Isbasatis.Entities.Context;
using DevExpress.XtraPrinting;
using IsbaSatis.BackOffice.Stoklar;
using DevExpress.XtraWizard;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmEtiketOlustur : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor = new XtraReport();
        IsbaSatisContext context = new IsbaSatisContext();
        List<Isbasatis.Entities.Tables.Stok> stokEntitiy = new List<Isbasatis.Entities.Tables.Stok>();
        public frmEtiketOlustur()
        {

            InitializeComponent();
            gridControl1.DataSource = stokEntitiy;

        }
        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm * 3.779527559);
        }

        private void wizardControl2_FinishClick(object sender, CancelEventArgs e)
        {
            rapor.DataSource = stokEntitiy;
            rapor.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            rapor.Height = mmToPixel(Convert.ToInt32(txtDikeyUzunluk.Value));
            rapor.Width = mmToPixel(Convert.ToInt32(txtYatayUzunluk.Value));
            rapor.Margins.Top = mmToPixel(Convert.ToInt32(txtMarginUst.Value));
            rapor.Margins.Bottom = mmToPixel(Convert.ToInt32(txtMarginAlt.Value));
            rapor.Margins.Left = mmToPixel(Convert.ToInt32(txtMarginSol.Value));
            rapor.Margins.Right = mmToPixel(Convert.ToInt32(txtMarginSağ.Value));
            rapor.RollPaper = chkRulo.Checked;

            DetailBand detail = new DetailBand();
            detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            detail.MultiColumn.ColumnWidth = mmToPixel(Convert.ToInt32(txtUzunluk.Value));
            detail.Height = mmToPixel(Convert.ToInt32(txtGenislik.Value));
            
            detail.MultiColumn.ColumnSpacing = mmToPixel(Convert.ToInt32(txtAraBosluk.Value));
            rapor.Bands.Add(detail);
            frmRaporDuzenle frm = new frmRaporDuzenle(rapor);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    stokEntitiy.Add(itemStok);
                }
            }
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
        }

        private void wizardControl2_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page==completionWizardPage2 && e.Direction==Direction.Forward && gridView1.RowCount==0)
            {
                MessageBox.Show("Listeye Hiç bir Ürün Eklenmedi");
                e.Cancel = true;
            }
        }
    }
}