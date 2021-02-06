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

namespace IsbaSatis.BackOffice.Cari
{
    public partial class frmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDAL = new CariDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        private int _cariId;
        public frmCariHareket(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
        
            var cariEntity = cariDAL.GetByFilter(context, c => c.Id == _cariId);
            lblBaslik.Text = cariEntity.CariKodu + " - " + cariEntity.CariAdi + " Harketleri";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void frmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridcontFisToplam.DataSource=cariDAL.CariFisAyrintiGenelToplam(context, _cariId);
            gridcontBakiye.DataSource = cariDAL.CariGenelToplam(context,_cariId );
            gridcontCariHareket.DataSource= cariDAL.CariFisAyrinti(context,_cariId );
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}