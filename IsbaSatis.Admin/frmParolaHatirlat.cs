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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Data_Access;

namespace IsbaSatis.Admin
{
    public partial class frmParolaHatirlat : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        Kullanici _entity;
        public frmParolaHatirlat(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatırlatma.Text = _entity.HatirlatmaSorusu;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap==txtCevap.Text && txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.Parola = txtParola.Text;
                kullaniciDAL.AddOrUpdate(context,_entity);
                context.SaveChanges();
                MessageBox.Show("Parolanız Başarıyla Değiştirildi.");
                this.Close();
            }
        }
    }
}