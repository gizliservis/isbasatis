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
    public partial class frmBankaBakiyeRpt : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        BankaDAL bankaDal = new BankaDAL();
        private ExportTool export;
        string filename = "BankaBakiye.xml";
        public frmBankaBakiyeRpt()
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
        public void listele()
        {
            gridControlBanka.DataSource = bankaDal.BankaHrkListele(context);
        }
    }
}