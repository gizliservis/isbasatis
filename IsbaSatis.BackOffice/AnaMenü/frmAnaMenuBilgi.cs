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

namespace IsbaSatis.BackOffice.AnaMenü
{
    public partial class frmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frmStok frmStok = new frmStok();
            frmStok.MdiParent = this;
            frmStok.Show();
        }
    }
}