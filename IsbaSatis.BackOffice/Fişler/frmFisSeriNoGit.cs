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

namespace IsbaSatis.BackOffice.Fişler
{
    public partial class frmFisSeriNoGit : DevExpress.XtraEditors.XtraForm
    {
        public string VeriSeriNo;
   
        public frmFisSeriNoGit(string veri, bool Kilitli = true)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] veriListesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)
                {
                    listSeriNo.Items.Add(item);
                }
            }
            if (Kilitli)
            {
                grpMenu.Enabled = false;
            }

        }
        void KayitAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            grpBilgi.Enabled = true;
            txtSeriNo.Focus();
        }
        void KayitKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            grpBilgi.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void frmFisSeriNoGit_Load(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Remove(listSeriNo.SelectedItem);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFisSeriNoGit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listSeriNo.Items.Count != 0)
            {
                foreach (var item in listSeriNo.Items)
                {
                    VeriSeriNo += item + System.Environment.NewLine;

                }
            }

        }
    }
}