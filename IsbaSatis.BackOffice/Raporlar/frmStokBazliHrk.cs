using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmStokBazliHrk : DevExpress.XtraEditors.XtraForm
    {
        int _stokId;
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public frmStokBazliHrk(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
        }

        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = stokHareketDal.StokBazliRapor(_stokId, context, dateBaslangic.DateTime, dateBitis.DateTime);
        }
    }
}