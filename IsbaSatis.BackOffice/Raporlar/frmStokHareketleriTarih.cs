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
    public partial class frmStokHareketleriTarih : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public frmStokHareketleriTarih()
        {
            InitializeComponent();
            dateBitis.DateTime = DateTime.Now;
            dateBaslangic.DateTime = DateTime.Now;
        }
   
        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            gridControl1.DataSource = stokHareketDal.StokKarZarar(context, dateBaslangic.DateTime, dateBitis.DateTime);
        }
    }
}