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

namespace IsbaSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuruHareketleri : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        OdemeTuruDAL odemeTuruDAL = new OdemeTuruDAL();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        private int _odemeTuruId;
        public frmOdemeTuruHareketleri(int odemeTuruId)
        {
            InitializeComponent();
            _odemeTuruId = odemeTuruId;
            var odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);
            lblBaslik.Text = odemeTuruBilgi.OdemeTuruKodu + " - " + odemeTuruBilgi.OdemeTuruAdi + " Hareketleri";
            listele();
        }

        private void frmOdemeTuruHareketleri_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            gridcontKasaHareket.DataSource = kasaHareketDAL.GetAll(context, c => c.OdemeTuruId == _odemeTuruId);
            gridcontOdemeTuruToplam.DataSource = odemeTuruDAL.KasaToplamListele(context, _odemeTuruId);
            gridcontGenelToplam.DataSource = odemeTuruDAL.GenelToplamListele(context, _odemeTuruId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
             gridKasaHareket.OptionsView.ShowAutoFilterRow = false?true:false;
             
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}