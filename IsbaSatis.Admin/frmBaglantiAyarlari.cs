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
using Isbasatis.Entities.Tools.LoadingTool;

namespace IsbaSatis.Admin
{
    public partial class frmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        LoadingTool lodingTool;
        private bool kaydedildi = false;
        public frmBaglantiAyarlari()
        {
            InitializeComponent();
            lodingTool = new LoadingTool(this);

        }
        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServer.Text;
            connectionStringBuilder.InitialCatalog = "İsba" + txtDbAdi.Text + "_" + DateTime.Now.Year.ToString();
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
                connectionStringBuilder.InitialCatalog = "İsba" + txtDbAdi.Text + DateTime.Now.Year.ToString();
                MessageBox.Show("Sectiğiniz Serverda Belittiğiniz Database Yoksa Bu Mesajdan Sonra Oluşturulacak.Bu İşlem Uzun Sürebilir. ");
                lodingTool.AnimasyonBaslat();
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa, "1");
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, "1");
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
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "Nakit",
                            OdemeTuruKodu = "S001",
                            Aciklama = "Sistem tarafından otomatik açılmıştır"

                        });
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "Kredi",
                            OdemeTuruKodu = "S002",
                            Aciklama = "Sistem tarafından otomatik açılmıştır"

                        });
                        context.Kodlar.Add(new Kod
                        {
                            OnEki="FÖ",
                            SonDeger=1,
                            Tablo="Fis"
                            
                        });
                        context.Kasalar.Add(new Kasa
                        {
                            KasaKodu ="K.001",
                            KasaAdi ="Merkez",
                            YetkiliAdi="Sistem",
                            YetkiliKodu="Y.001",
                            Aciklama="Sistem Tarafından Oluşturulmuştur"
                        });
                        context.Depolar.Add(new Depo
                        {
                            DepoKodu = "D.001",
                            DepoAdi = "Merkez",
                            YetkiliAdi = "Sistem",
                            YetkiliKodu = "Y.001",
                            Aciklama = "Sistem Tarafından Oluşturulmuştur"
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            Tanimi = "Adet",
                            Turu = "Birimi",
                            Aciklama = "Sistem Tarafından Oluşturulmuştur"
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            Tanimi = "KG",
                            Turu = "Birimi",
                            Aciklama = "Sistem Tarafından Oluşturulmuştur"
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            Tanimi = "Paket",
                            Turu = "Birimi",
                            Aciklama = "Sistem Tarafından Oluşturulmuştur"
                        });
                        context.SaveChanges();

                    }
                }
                kaydedildi = true;
                lodingTool.AnimasyonBitir();
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