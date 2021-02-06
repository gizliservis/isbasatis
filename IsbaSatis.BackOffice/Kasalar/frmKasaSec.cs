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
                string kasakodu = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
                secildi = true;
                this.Close();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}