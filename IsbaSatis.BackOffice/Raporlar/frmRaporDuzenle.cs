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

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRaporDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporDuzenle(XtraReport rapor=null)
        {
            InitializeComponent();
            reportDesigner1.OpenReport(rapor);
        }

       
    }
}