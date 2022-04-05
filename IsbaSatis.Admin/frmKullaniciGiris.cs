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
using Isbasatis.Entities.Tools;
using Isbasatis.Entities.Tables;
using System.Data.SqlClient;

namespace IsbaSatis.Admin
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context;
        private bool girisBasarili = false;
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        
        public frmKullaniciGiris()
        {
            InitializeComponent();
            frmSirketMenu form = new frmSirketMenu();
            form.ShowDialog();
            connectionStringBuilder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
            if (!String.IsNullOrEmpty(form.secilenDonem))
            {
                connectionStringBuilder.InitialCatalog = form.secilenDonem;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                context = new IsbaSatisContext();

            }
            if (!ConnectionTool.CheckConnection(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi)))
            {
                frmBaglantiAyarlari frm = new frmBaglantiAyarlari();
                frm.ShowDialog();
            }
           
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c=>c.KullaniciAdi==txtKullanici.Text && c.Parola==txtParola.Text))
            {
                girisBasarili = true;
                RolTool.KullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullanici.Text);
                this.Close();

            }
            else
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı Veya Parola Yanlış");
                txtKullanici.Text = null;
                txtParola.Text = null;  
            }
        }

        private void frmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisBasarili)
            {
                Application.Exit();
            }
            
           
               
          
        }

        private void btnParolaUnuttum_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c=>c.KullaniciAdi==txtKullanici.Text))
            {
                frmParolaHatirlat frm = new frmParolaHatirlat(txtKullanici.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yazdığınız Kullanıcı Adı Kayıtlarda Yok.");
            }
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }
    }
}