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
using System.Xml.Linq;
using Isbasatis.Entities.Tables.Other_Tables;
using System.Net;
using System.IO;
using Isbasatis.Entities.Tools;

namespace IsbaSatis.BackOffice.DovizKurları
{
    public partial class frmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son Güncelleme Tarihi : " + info.LastWriteTime.ToString();
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }
        private void Guncelle(bool indir = true)
        {
            if (indir)
            {
                using (WebClient kurIndir = new WebClient())
                {
                    kurIndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();
            }
            ExchangeTool Doviz = new ExchangeTool();

            gridControl1.DataSource = Doviz.DovizKuruCek();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}