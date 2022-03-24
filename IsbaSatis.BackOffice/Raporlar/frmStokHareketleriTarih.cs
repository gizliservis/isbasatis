using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
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
        ExportTool export;
        public frmStokHareketleriTarih()
        {
            InitializeComponent();
            dateBitis.DateTime = DateTime.Now;
            dateBaslangic.DateTime = DateTime.Now;
            export = new ExportTool(this, gridView1, dropDownButton1);
        }
   
        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            gridControl1.DataSource = stokHareketDal.StokKarZarar(context, dateBaslangic.DateTime, dateBitis.DateTime);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}