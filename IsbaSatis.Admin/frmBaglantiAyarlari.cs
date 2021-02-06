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
using System.Data.SqlClient;
using Isbasatis.Entities.Tools;
using DevExpress.XtraTreeList.Data;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Tables;
using System.Drawing.Text;

namespace IsbaSatis.Admin
{
    public partial class frmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        private bool kaydedildi = false;
        public frmBaglantiAyarlari()
        {
            InitializeComponent();
           
        }
        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServer.Text;
            connectionStringBuilder.InitialCatalog = txtDbAdi.Text;
            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;

            }
            else
            {
                connectionStringBuilder.UserID = txtKullanici.Text;
                connectionStringBuilder.Password = txtParola.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = txtDbAdi.Text;
                MessageBox.Show("Sectiğiniz Serverda Belittiğiniz Database Yoksa Bu Mesajdan Sonra Oluşturulacak.Bu İşlem Uzun Sürebilir. ");
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                SettingsTool.save();
                using (var context = new IsbaSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "yönetici"))
                    {
                        context.Kullanicilar.Add(new Kullanici
                        {
                            KullaniciAdi = "yönetici",
                            Adi = "isba",
                            Soyadi = "Yazılım",
                            Parola = "2515",
                            KayitTarihi = DateTime.Now
                        });
                        context.SaveChanges();
                    }
                }
                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız");
            }
          
        }

        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtKullanici.Enabled = true;
                txtParola.Enabled = true;
            }
            else
            {
                txtKullanici.Enabled = false;
                txtParola.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı Başarılı");
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız");
            }

        }

        private void frmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                MessageBox.Show("Uygulamada Bağlantı Cümlesi Olmadıgından Kapatılacak.");
                Application.Exit();
            }
        }
    }
}