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
using IsbaSatis.Raporlar.Stok;
using System.Reflection;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmRaporListele : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor;
        public frmRaporListele()
        {
            InitializeComponent();
        }

        private void navBarLink_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            filterControl1.FilterString = null;
            var buton = sender as NavBarItem;
            Type tip = Assembly.Load("IsbaSatis.Raporlar").GetTypes().SingleOrDefault(c => c.Name == buton.Name.Replace("link", ""));
            rapor = (XtraReport)Activator.CreateInstance(tip);
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            filterControl1.SourceControl = rapor.DataSource;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmRaporGoruntule form = new frmRaporGoruntule(rapor);
            rapor.FilterString = filterControl1.FilterString;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}