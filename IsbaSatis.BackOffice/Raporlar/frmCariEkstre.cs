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
    public partial class frmCariEkstre : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        FisDAL fisdal = new FisDAL();
        int _cariId;
        private ExportTool export;
        string filename = "CariEkstre.xml";
        public frmCariEkstre(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
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
            gridControl1.DataSource = fisdal.CariEkstre(context, _cariId, dateBaslangic.DateTime, dateBitis.DateTime);
        }
    }
}