using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Stoklar
{
    public partial class frmExcellAktar : DevExpress.XtraEditors.XtraForm
    {
        ExcellAktarimTool exc = new ExcellAktarimTool();
        StokDAL stokDal = new StokDAL();
        Isbasatis.Entities.Tables.Stok stkk = new Isbasatis.Entities.Tables.Stok();
        IsbaSatisContext context = new IsbaSatisContext();

        public frmExcellAktar()
        {
            InitializeComponent();
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             gridControl1.DataSource = exc.ExcellAktar(textEdit1.Text);
            gridControl1.DataSource= context.Stoklar.Local.ToBindingList();


        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                Isbasatis.Entities.Tables.Stok stk = new Isbasatis.Entities.Tables.Stok
                {
                    Durumu=Convert.ToBoolean(gridView1.GetRowCellValue(i, colDurumu)),
                    StokKodu = gridView1.GetRowCellValue(i, colStokKodu).ToString(),
                    StokAdi = gridView1.GetRowCellValue(i, colStokAdi).ToString(),



                };
            }
            
        }
    }
}