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
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Context;

namespace IsbaSatis.BackOffice.Kasalar
{
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL = new KasaDAL();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        private int _kasaId ;
        public frmKasaHareketleri(int kasaId)
        {
            InitializeComponent();
              _kasaId = kasaId;
            var kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            lblBaslik.Text = kasaBilgi.KasaKodu + " - " + kasaBilgi.KasaAdi + " Harketleri";

        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }
        public void Guncelle()
        {
            gridcontKasaHareket.DataSource = kasaHareketDAL.GetAll(context, c=>c.KasaId==_kasaId);
            gridcontOdemeTuruToplam.DataSource = kasaDAL.OdemeTuruToplamListele(context, _kasaId);
            gridcontGenelToplam.DataSource = kasaDAL.GenelToplamListele(context, _kasaId);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}