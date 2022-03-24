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
    public partial class frmCariHrkRaporu : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        CariDAL cariDal = new CariDAL();
        int _cariId;
        public frmCariHrkRaporu(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;

        }

        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            gridControl1.DataSource = cariDal.CariHareket(context, _cariId, dateBaslangic.DateTime, dateBitis.DateTime);
        }
    }
}