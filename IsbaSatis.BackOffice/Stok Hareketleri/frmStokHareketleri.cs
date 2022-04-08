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
using IsbaSatis.BackOffice.Fişler;
using Isbasatis.Entities.Tools;
using System.IO;

namespace IsbaSatis.BackOffice.Stok_Hareketleri
{
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        private ExportTool export;
        string filename = "StokHareketRaporu.xml";
        public frmStokHareketleri()
        {
            InitializeComponent();
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
        }
        private void listele()
        {
           gridControl1.DataSource= stokHareketDAL.GetAll(context);
        }
        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repoSeriNoo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Veri = Convert.ToString(gridView1.GetFocusedRowCellValue(colSeriNo));
            frmFisSeriNoGit frm = new frmFisSeriNoGit(Veri);
           
            frm.ShowDialog();
            
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(gridView1.GetFocusedRowCellValue(colFisKodu).ToString());
            frm.ShowDialog();

        }
    }
}