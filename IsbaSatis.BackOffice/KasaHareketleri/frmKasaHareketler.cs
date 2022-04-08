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

namespace IsbaSatis.BackOffice.KasaHareketleri
{
    public partial class frmKasaHareketler : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        private ExportTool export;
        string filename = "KasaHareketRpt.xml";
        string _raporIsim;
        int? _id;
        public frmKasaHareketler(string raporIsim,int? id)
        {
            InitializeComponent();
            _raporIsim = raporIsim;
            _id = id;
            listele();
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // gridView1.ShowPrintPreview();
            listele();
        }
        private void listele()
        {

            if (_raporIsim == "Kasa Hareketler Raporu")
            {
                gridControl1.DataSource = kasaHareketDAL.GetAll(context);
            }
            else if (_raporIsim == "Kasa Bazlı Hareket Raporu")
            {
                gridControl1.DataSource = kasaHareketDAL.GetAll(context,c=>c.KasaId==_id);
            }

            //  gridControl1.DataSource = kasaHareketDAL.GetByFilter(context,c=>c.KasaId==1);
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
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

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(gridView1.GetFocusedRowCellValue(colFisKodu).ToString());
            frm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}