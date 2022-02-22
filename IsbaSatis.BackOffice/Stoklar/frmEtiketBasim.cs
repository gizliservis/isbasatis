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

namespace IsbaSatis.BackOffice.Stoklar
{
    public partial class frmEtiketBasim : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stkDal = new StokDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public frmEtiketBasim()
        {
            InitializeComponent();
            listele();
        }
        public void listele()
        {
            gridControl1.DataSource = stkDal.GetAll(context);
        }
    }
}