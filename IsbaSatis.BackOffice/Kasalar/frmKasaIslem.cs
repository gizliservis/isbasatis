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
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Cari
{
    public partial class frmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL = new KasaDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool Kaydedildi = false;
        private Kasa _entity;
        public frmKasaIslem(Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("text", _entity, "YetkiliAdi");
            txtAciklama.DataBindings.Add("text", _entity, "Aciklama");
        }

        private void frmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDAL.AddOrUpdate(context,_entity))
            {
                kasaDAL.Save(context);
                Kaydedildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}