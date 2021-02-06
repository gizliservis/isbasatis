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
    public partial class frmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGoruntule(XtraReport rapor)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = rapor;
        }
    }
}