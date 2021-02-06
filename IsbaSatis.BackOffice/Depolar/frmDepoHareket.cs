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

namespace IsbaSatis.BackOffice.Depolar
{
    public partial class frmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        private int _depoId;
        public frmDepoHareket(int depoId)
        {
            InitializeComponent();
            _depoId = depoId;
            var depo = context.Depolar.SingleOrDefault(c => c.Id == _depoId);
            lblBaslik.Text = depo.DepoKodu + " - " + depo.DepoAdi + " Harketleri";
        }

        private void frmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridcontHareket.DataSource = stokHareketDAL.GetAll(context, c => c.DepoId == _depoId);
            gridcontDepoStok.DataSource = stokHareketDAL.DepoStokListele(context, _depoId);
            gridcontIstatistik.DataSource = stokHareketDAL.DepoIstatistikListele(context, _depoId);
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
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}