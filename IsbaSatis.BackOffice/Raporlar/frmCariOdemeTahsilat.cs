using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
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

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmCariOdemeTahsilat : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        CariDAL cariDal = new CariDAL();
        int _cariId;
        string filename = "frmCariOdemeTah.xml";
        ExportTool export;

        public frmCariOdemeTahsilat(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            export = new ExportTool(this,gridView1,dropDownButton1,filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
        
        }

        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            gridControl1.DataSource = cariDal.CariTahOdeme(context, _cariId, dateBaslangic.DateTime, dateBitis.DateTime);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.SaveLayoutToXml(filename);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}