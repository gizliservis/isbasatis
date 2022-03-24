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
    public partial class frmStokBakiyeRaporu : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        StokDAL stokDal = new StokDAL();
        private ExportTool export;
        public frmStokBakiyeRaporu()
        {
            InitializeComponent();
            Listele();
            export = new ExportTool(this, gridView1, dropDownButton1);
        }
        public void Listele()
        {
            gridControl1.DataSource = stokDal.StokListele(context);
        }
    }
}