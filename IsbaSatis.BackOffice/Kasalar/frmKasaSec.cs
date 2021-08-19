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
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Kasalar
{
    public partial class frmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL = new KasaDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public Kasa entity = new Kasa();
        public bool secildi = false;
        public List<Isbasatis.Entities.Tables.Kasa> secilen = new List<Isbasatis.Entities.Tables.Kasa>();
        public frmKasaSec()
        {
            InitializeComponent();
        }

        private void frmKasaSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = kasaDAL.KasaListele(context);
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {

                foreach (var row in gridView1.GetSelectedRows())
                {
                    string Kasakodu = gridView1.GetRowCellValue(row, colKasaKodu).ToString();
                    secilen.Add(context.Kasalar.SingleOrDefault(c => c.KasaKodu == Kasakodu));

                }
                secildi = true;
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Seçilen Bir Cari Bulunamadı");
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