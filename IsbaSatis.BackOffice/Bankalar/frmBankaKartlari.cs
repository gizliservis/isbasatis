using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Bankalar
{
    public partial class frmBankaKartlari : DevExpress.XtraEditors.XtraForm
    {
        BankaDAL bankaDal = new BankaDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool Kaydedildi=false;
       private Banka _entity;
        public frmBankaKartlari(Banka entity)
        {
            InitializeComponent();
            _entity = entity;
            txtHesapKodu.DataBindings.Add("text", _entity, "HesapKodu");
            txtHesapIsmi.DataBindings.Add("text", _entity, "HesapIsmi");
            txtBankasi.DataBindings.Add("text", _entity, "Bankasi");
            txtSube.DataBindings.Add("text", _entity, "Sube");
            txtIbanNo.DataBindings.Add("text", _entity, "IbanNo");
            txtHesapNo.DataBindings.Add("text", _entity, "HesapNo");
            txtYetkiliAdi.DataBindings.Add("text", _entity, "YetkiliAdi");
            txtTelefonu.DataBindings.Add("text", _entity, "YetkiliTelefonu");


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (bankaDal.AddOrUpdate(context,_entity))
            {
                bankaDal.Save(context);
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