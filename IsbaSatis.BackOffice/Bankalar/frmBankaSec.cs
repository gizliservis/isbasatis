using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Bankalar
{
    public partial class frmBankaSec : DevExpress.XtraEditors.XtraForm
    {
        BankaDAL bankaDAL = new BankaDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool secildi = false;
        public List<Banka> secilen = new List<Banka>();
        public bool kaydedildi = false;
        public frmBankaSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            gridControl1.DataSource = bankaDAL.GetAll(context);
        }

        private void btnBankaSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string hesapKodu = gridView1.GetRowCellValue(row, colHesapKodu).ToString();
                    secilen.Add(context.Bankalar.SingleOrDefault(c => c.HesapKodu == hesapKodu));
                }
                secildi = true;
                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Banka Bulunmamakta.", "Uyarı");
                return;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow == true)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}