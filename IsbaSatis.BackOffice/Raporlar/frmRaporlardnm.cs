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
    public partial class frmRaporlardnm : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        FisDAL fisDAL = new FisDAL();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        

        public frmRaporlardnm()
        {
            InitializeComponent();
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
        }

        void listele(DateTime baslangic, DateTime bitis )
        {
            gridControl1.DataSource = kasaHareketDAL.OdemeTuruSatisListele(context, baslangic, bitis);

        }
        private void BtnHazırla_Click(object sender, EventArgs e)
        {
          
            listele(dateBaslangic.DateTime,dateBitis.DateTime);
        }
    }
}