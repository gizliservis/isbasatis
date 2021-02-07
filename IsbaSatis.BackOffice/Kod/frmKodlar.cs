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
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Data.Entity;
using DevExpress.XtraGrid;

namespace IsbaSatis.BackOffice.Kod
{
    public partial class frmKodlar : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        KodDAL kodDal = new KodDAL();
        private string _tablo;
        public frmKodlar(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            context.Kodlar.Where(c => c.Tablo == _tablo).Load();
            gridControl2.DataSource = context.Kodlar.Local.ToBindingList();
        }

        private void grpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            this.Hide();
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView2.FocusedRowHandle!=GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           Isbasatis.Entities.Tables.Kod row = (Isbasatis.Entities.Tables.Kod)e.Row;
            if (context.Kodlar.Local.Any(c=>c.OnEki==row.OnEki))
            {
                MessageBox.Show("Aynı Ön Ekle Kod Kaydedilemez.");
                gridView2.CancelUpdateCurrentRow();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView2.DeleteSelectedRows();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}