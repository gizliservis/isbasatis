using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Bankalar
{
    public partial class frmBanka : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        BankaDAL bankaDAL = new BankaDAL();
        int secilen;
        private ExportTool export;
        string filename = "Banka.xml";

        public frmBanka()
        {
            InitializeComponent();
            export = new ExportTool(this, gridBanka, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridBanka.RestoreLayoutFromXml(filename);
            }
            listele();
        }
        void listele()
        {
            gridControlBanka.DataSource = bankaDAL.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmBankaKartlari frm = new frmBankaKartlari(new Banka());
            frm.ShowDialog();
            listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridBanka.GetFocusedRowCellValue(colId));
            frmBankaKartlari form = new frmBankaKartlari(bankaDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridBanka.GetFocusedRowCellValue(colId));
                bankaDAL.Delete(context, c => c.Id == secilen);
                bankaDAL.Save(context);
                listele();


            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridBanka.OptionsView.ShowAutoFilterRow == true)
            {
                gridBanka.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridBanka.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}