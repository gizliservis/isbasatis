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
using IsbaSatis.BackOffice.Kasalar;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tools;
using Isbasatis.Entities.Context;

namespace IsbaSatis.BackOffice.Fişler
{
    public partial class frmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        public KasaHareket entity;
        Nullable<decimal> gelenTutar;
        private Kasa _kasaBilgi = null;
        private OdemeTuru _odemeTuruBilgi = null;
        public frmOdemeEkrani(int odemeTuruId, Nullable<decimal> odenmesiGereken = null)
        {
            InitializeComponent();
            int kasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa));
            _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            _odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);
            txtOdemeTuru.Text = _odemeTuruBilgi.OdemeTuruAdi;
            txtKasaKodu.Text = _kasaBilgi.KasaKodu;
            txtKasaAdi.Text = _kasaBilgi.KasaAdi;
            if (odenmesiGereken != null)
            {
                gelenTutar = odenmesiGereken.Value;
            }
            else
            {
                txtTutar.Properties.Buttons[1].Visible = false;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmKasaSec kasaSec = new frmKasaSec();
            kasaSec.ShowDialog();
            if (kasaSec.secildi)
            {
                _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaSec.entity.Id);
                txtKasaKodu.Text = kasaSec.entity.KasaKodu;
                txtKasaAdi.Text = kasaSec.entity.KasaAdi;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int error = 0;
            if (txtKasaAdi.Text == "")
            {
                message += "Kasa bilgileri boş bırakılamaz." + System.Environment.NewLine;
                error++;
            }
            if (txtTutar.Value <= 0)
            {
                message += "tutar 0 değerinden küçük veya 0 değerine eşit olamaz." + System.Environment.NewLine;
                error++;
            }
            if (txtTutar.Value > gelenTutar && gelenTutar != null)
            {
                message += "Eklenen tutar Ödenmesi Gereken tutardan büyük olamaz." + System.Environment.NewLine;
                error++;
            }
            if (error != 0)
            {
                MessageBox.Show(message);
                return;
            }

            entity = new KasaHareket();

            entity.OdemeTuruId = _odemeTuruBilgi.Id;
            entity.KasaId = _kasaBilgi.Id;

            entity.Tutar = txtTutar.Value;
            entity.Aciklama = txtAciklama.Text;
            this.Close();
        }

        private void txtTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                txtTutar.Value = gelenTutar.Value;
            }
        }
    }
}