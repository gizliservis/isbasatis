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

namespace IsbaSatis.BackOffice.Depolar
{
    public partial class frmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        private int _stokId;
        public Depo entity = new Depo();
        public bool secildi = false;
        public frmDepoSec(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;

        }

        private void frmDepoSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = depoDAL.DepoBazindaStokListele(context, _stokId);
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                string depoKodu = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }

        }
    }
}