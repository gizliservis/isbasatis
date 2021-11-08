using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRprDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public frmRprDuzenle(XtraReport rapor)
        {
            InitializeComponent();
            ReportDesignTool designTool = new ReportDesignTool(rapor);
            designTool.ShowDesigner();

        }
    }
}