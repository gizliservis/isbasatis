using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using IsbaSatis.BackOffice.Cari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Bankalar
{
    public partial class frmBankaIslemleri : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        Fis _fisEntity = new Fis();
        BankaHareket bankaEntity = new BankaHareket();
        BankaHareketDAL bankaHareketDAL = new BankaHareketDAL();
        FisDAL fisDAL = new FisDAL();
        private Nullable<int> _cariId;
        private Nullable<int> _bankaId;
        private string  _cariTuru;
        private string _faturaUnvan;
        private string _cepTelefonu;
        private string _il;
        private string _ilce;
        private string _semt;
        private string _adres;
        private string _vergiDairesi;
        private string _vergiNo;



        public frmBankaIslemleri(string fisKodu)
        {
            InitializeComponent();
            if (fisKodu != null)
            {
                _fisEntity = context.fisler.SingleOrDefault(c => c.FisKodu == fisKodu);
            }
            context.Bankalar.Load();
            context.Cariler.Load();
            cmbIslemTuru.SelectedIndex = 0;
            txtTutar.Value = 0;
            txtTarih.DateTime = DateTime.Now;

        }
        void temizle()
        {
            txtFisKodu.Text = null;
            txtAciklama.Text = null;
            txtTarih.DateTime = DateTime.Now;
            btnBankaAdi.Text = null;
            btnCariAdi.Text = null;
            cmbIslemTuru.SelectedIndex = 0;
            txtTutar.Value = 0;

        }

        private void btnCariAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCariSec frm = new frmCariSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Isbasatis.Entities.Tables.Cari entity = frm.secilen.FirstOrDefault();

                _cariId = entity.Id;
                _cariTuru = entity.CariTuru;
                _faturaUnvan = entity.FaturaUnvani;
                _cepTelefonu = entity.CepTelefonu;
                _il = entity.Il;
                _ilce = entity.Ilce;
                _semt = entity.Semt;
                _vergiDairesi = entity.VergiDairesi;
                _vergiNo = entity.VergiNo;
                _adres = entity.Adres;

                _fisEntity.CariId = _cariId;
                btnCariAdi.Text = entity.CariAdi;

            }
        }

        private void btnBankaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmBankaSec frm = new frmBankaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Isbasatis.Entities.Tables.Banka entity = frm.secilen.FirstOrDefault();
                _bankaId = entity.Id;

                bankaEntity.BankaId = Convert.ToInt32(_bankaId) ;
                btnBankaAdi.Text = entity.HesapIsmi;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 0)
            {
                _fisEntity.FisKodu = txtFisKodu.Text;
                _fisEntity.FisTuru = cmbIslemTuru.Text;
                _fisEntity.CariId = _cariId;
                _fisEntity.FaturaUnvani = _faturaUnvan;
                _fisEntity.CariTuru = _cariTuru;
                _fisEntity.CepTelefonu = _cepTelefonu;
                _fisEntity.Il = _il;
                _fisEntity.Ilce = _ilce;
                _fisEntity.Semt = _semt;
                _fisEntity.Adres = _adres;
                _fisEntity.VergiDairesi = _vergiDairesi;
                _fisEntity.VergiNo = _vergiNo;
                _fisEntity.Alacak = txtTutar.Value;
                _fisEntity.ToplamTutar = txtTutar.Value;
                _fisEntity.Tarih = txtTarih.DateTime;
                _fisEntity.Aciklama = txtAciklama.Text;
                bankaEntity.FisKodu = txtFisKodu.Text;
                bankaEntity.Hareket = cmbIslemTuru.Text;
                bankaEntity.BankaId = Convert.ToInt32(_bankaId);
                bankaEntity.CariId = _cariId;
                bankaEntity.Tarih = txtTarih.DateTime;
                bankaEntity.Tutar = txtTutar.Value;
                bankaEntity.Aciklama = txtAciklama.Text;
                bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                fisDAL.AddOrUpdate(context,_fisEntity);
                context.BankaHareketleri.Load();
                context.fisler.Load();
                context.SaveChanges();
                temizle();

            }
          
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}