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
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Cari
{
    public partial class frmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL CariDAL = new CariDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool secildi;
        public List<Isbasatis.Entities.Tables.Cari> secilen = new List<Isbasatis.Entities.Tables.Cari>();
        
        public frmCariSec(bool coklusecim = false)
        {
            InitializeComponent();
            if (coklusecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            gridControl1.DataSource = CariDAL.CariListele(context);
        }

        private void frmCariSec_Load(object sender, EventArgs e)
        {
           
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {

                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));
                
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
    }
}