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

namespace IsbaSatis.BackOffice.Stoklar
{
    public partial class frmStokHareket : DevExpress.XtraEditors.XtraForm
    {
     
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        private int _stokId;
        public frmStokHareket(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
            var stok = context.Stoklar.SingleOrDefault(c => c.Id == _stokId);
            lblBaslik.Text = stok.StokKodu + " - " +stok.StokAdi+" Harketleri";
        }

        private void frmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridControl1.DataSource = stokHareketDAL.GetAll(context, c => c.StokId == _stokId);
            gridControl3.DataSource = stokHareketDAL.GetGenelStok(context, _stokId);
            gridControl2.DataSource = stokHareketDAL.GetDepoStok(context, _stokId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow ==true)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
            
        }
    }
}