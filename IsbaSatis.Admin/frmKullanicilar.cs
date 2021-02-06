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
using Isbasatis.Entities.Tables;

namespace IsbaSatis.Admin
{
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        string secilen;
        public frmKullanicilar()
        {
            InitializeComponent();
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciIslem frm = new frmKullaniciIslem(new Kullanici());
            frm.ShowDialog();
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            frmKullaniciGiris frm = new frmKullaniciGiris();
            frm.ShowDialog();
        }
        private void Guncelle()
        {
            gridControl1.DataSource = kullaniciDAL.GetAll(context); 
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           secilen = gridView1.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            frmKullaniciIslem form = new frmKullaniciIslem(kullaniciDAL.GetByFilter(context, c => c.KullaniciAdi == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Guncelle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}