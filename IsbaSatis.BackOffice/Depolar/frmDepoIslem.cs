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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;

namespace IsbaSatis.BackOffice.Depolar
{
    public partial class frmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        DepoDAL depoDAL = new DepoDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        private Depo _entity;
        public bool Kaydedildi = false;
        public frmDepoIslem(Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtDepoKodu.DataBindings.Add("text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("text", _entity, "DepoAdi");
            txtYetkiliKodu.DataBindings.Add("text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("text", _entity, "Telefon");
            txtIl.DataBindings.Add("text", _entity, "Il");
            txtIlce.DataBindings.Add("text", _entity, "Ilce");
            txtSemt.DataBindings.Add("text", _entity, "Semt");
            txtAdres.DataBindings.Add("text", _entity, "Adres");
            txtAciklama.DataBindings.Add("text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDAL.AddOrUpdate(context, _entity))
            {
                depoDAL.Save(context);
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