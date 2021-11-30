using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using IsbaSatis.BackOffice.Cari;
using IsbaSatis.BackOffice.Kasalar;
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
        KasaHareket kasahareketEntity = new KasaHareket();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        FisDAL fisDAL = new FisDAL();
        frmCariSec frm = new frmCariSec();
        frmBankaSec formcuk = new frmBankaSec();
        frmKasaSec kfrm = new frmKasaSec();
        private Nullable<int> _cariId;
        private Nullable<int> _bankaId;
        private string _cariTuru;
        private string _faturaUnvan;
        private string _cepTelefonu;
        private string _il;
        private string _ilce;
        private string _semt;
        private string _adres;
        private string _vergiDairesi;
        private string _vergiNo;
        private string _kasaKodu;
        private int __kasaId;
        private string __kasaAdi;
        private string __yetkiliKodu;
        private string __yetkiliAdi;
        private string __aciklama;




        public frmBankaIslemleri(string fisKodu = null)
        {
            InitializeComponent();
            cmbIslemTuru.SelectedIndex = 0;
            txtTarih.DateTime = DateTime.Now;
            if (fisKodu != null)
            {
                _fisEntity = context.fisler.SingleOrDefault(c => c.FisKodu == fisKodu);
                context.Bankalar.Load();
                context.Cariler.Load();
                cmbIslemTuru.SelectedIndex = 0;
                txtTutar.Value = 0;
                txtTarih.DateTime = DateTime.Now;
                var cariBilgi = context.Cariler.SingleOrDefault(c => c.Id == _fisEntity.CariId);
                var banka = context.Bankalar.SingleOrDefault(c => c.Id == _fisEntity.BankaId);
                bankaEntity = context.BankaHareketleri.SingleOrDefault(c => c.FisKodu == _fisEntity.FisKodu);
                kasahareketEntity = context.KasaHareketleri.SingleOrDefault(c => c.FisKodu == _fisEntity.FisKodu);
                //_cariadi= cariBilgi.CariAdi.ToString() ;
                if (_fisEntity.FisTuru == "Gelen Havale" || _fisEntity.FisTuru == "Giden Havale" || _fisEntity.FisTuru == "Gelen EFT" || _fisEntity.FisTuru == "Giden EFT")
                {
                    btnCariAdi.Text = cariBilgi.CariAdi.ToString();
                    _cariId = cariBilgi.Id;
                }
                else
                {
                    btnCariAdi.Text = kasahareketEntity.Kasa.KasaAdi;
                    __kasaId = kasahareketEntity.KasaId;
                }

                btnBankaAdi.Text = banka.Bankasi;
                _bankaId = banka.Id;

                


                txtFisKodu.DataBindings.Add("Text", _fisEntity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbIslemTuru.DataBindings.Add("Text", _fisEntity, "Fisturu", false, DataSourceUpdateMode.OnPropertyChanged);
                txtTutar.DataBindings.Add("Value", _fisEntity, "ToplamTutar", true, DataSourceUpdateMode.OnPropertyChanged);
                txtTarih.DataBindings.Add("EditValue", _fisEntity, "Tarih", true, DataSourceUpdateMode.OnPropertyChanged);
                txtAciklama.DataBindings.Add("Text", _fisEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            }



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
            if (cmbIslemTuru.Text == "Bankaya Yatırılan Nakit")
            {//kasa secimi eklenecek 

                kfrm.ShowDialog();
                if (kfrm.secildi)
                {
                    Isbasatis.Entities.Tables.Kasa entity = kfrm.secilen.FirstOrDefault();

                    __kasaId = entity.Id;
                    _kasaKodu = entity.KasaKodu;
                    __kasaAdi = entity.KasaAdi;
                    __yetkiliAdi = entity.YetkiliAdi;
                    __yetkiliKodu = entity.YetkiliKodu;
                    __aciklama = entity.Aciklama;
                    btnCariAdi.Text = entity.KasaAdi;
                    lblCariAdi.Text = "Kasa Adı";
                }
            }
            else if (cmbIslemTuru.Text == "Bankadan Çekilen Nakit")
            {

                kfrm.ShowDialog();
                if (kfrm.secildi)
                {
                    Isbasatis.Entities.Tables.Kasa entity = kfrm.secilen.FirstOrDefault();

                    __kasaId = entity.Id;
                    _kasaKodu = entity.KasaKodu;
                    __kasaAdi = entity.KasaAdi;
                    __yetkiliAdi = entity.YetkiliAdi;
                    __yetkiliKodu = entity.YetkiliKodu;
                    __aciklama = entity.Aciklama;
                    btnCariAdi.Text = entity.KasaAdi;
                    lblCariAdi.Text = "Kasa Adı";
                }
            }
            else
            {
                //  frmCariSec frm = new frmCariSec();
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
                    lblCariAdi.Text = "Cari Adı";
                }
            }

        }

        private void btnBankaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            formcuk.ShowDialog();
            if (formcuk.secildi)
            {
                Isbasatis.Entities.Tables.Banka entity = formcuk.secilen.FirstOrDefault();
                _bankaId = entity.Id;

                bankaEntity.BankaId = Convert.ToInt32(_bankaId);
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
                _fisEntity.BankaId = Convert.ToInt32(_bankaId);
                bankaEntity.FisKodu = txtFisKodu.Text;
                bankaEntity.Hareket = "Banka Giriş";
                bankaEntity.BankaId = Convert.ToInt32(_bankaId);
                bankaEntity.CariId = _cariId;
                bankaEntity.Tarih = txtTarih.DateTime;
                bankaEntity.Tutar = txtTutar.Value;
                bankaEntity.Aciklama = txtAciklama.Text;
                bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                fisDAL.AddOrUpdate(context, _fisEntity);
                context.BankaHareketleri.Load();
                context.fisler.Load();
                context.SaveChanges();
                temizle();




            }
            else if (cmbIslemTuru.SelectedIndex == 1)
            {
                try
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
                    _fisEntity.Borc = txtTutar.Value;
                    _fisEntity.ToplamTutar = txtTutar.Value;
                    _fisEntity.Tarih = txtTarih.DateTime;
                    _fisEntity.Aciklama = txtAciklama.Text;
                    _fisEntity.BankaId = _bankaId;
                    bankaEntity.FisKodu = txtFisKodu.Text;
                    bankaEntity.Hareket = "Banka Çıkış";
                    bankaEntity.BankaId = Convert.ToInt32(_bankaId);
                    bankaEntity.CariId = _cariId;

                    bankaEntity.Tarih = txtTarih.DateTime;
                    bankaEntity.Tutar = txtTutar.Value;
                    bankaEntity.Aciklama = txtAciklama.Text;
                    bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                    fisDAL.AddOrUpdate(context, _fisEntity);
                    context.BankaHareketleri.Load();
                    context.fisler.Load();
                    context.SaveChanges();
                    temizle();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilgileri Kontrol Ediniz");
                }

            }
            else if (cmbIslemTuru.SelectedIndex == 2)
            {
                try
                {
                    _fisEntity.FisKodu = txtFisKodu.Text;
                    _fisEntity.FisTuru = cmbIslemTuru.Text;
                    _fisEntity.CariId = _cariId;
                    _fisEntity.FaturaUnvani = _faturaUnvan;
                    _fisEntity.CariTuru = _cariTuru;
                    _fisEntity.CepTelefonu = _cepTelefonu;
                    _fisEntity.BankaId = _bankaId;
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
                    bankaEntity.Hareket = "Banka Giriş";
                    bankaEntity.BankaId = Convert.ToInt32(_bankaId);
                    bankaEntity.CariId = _cariId;
                    bankaEntity.Tarih = txtTarih.DateTime;
                    bankaEntity.Tutar = txtTutar.Value;
                    bankaEntity.Aciklama = txtAciklama.Text;
                    bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                    fisDAL.AddOrUpdate(context, _fisEntity);
                    context.BankaHareketleri.Load();
                    context.fisler.Load();
                    context.SaveChanges();
                    temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgileri Kontrol Ediniz");
                }
            }
            else if (cmbIslemTuru.SelectedIndex == 3)
            {
                try
                {
                    _fisEntity.FisKodu = txtFisKodu.Text;
                    _fisEntity.FisTuru = cmbIslemTuru.Text;
                    _fisEntity.CariId = _cariId;
                    _fisEntity.FaturaUnvani = _faturaUnvan;
                    _fisEntity.CariTuru = _cariTuru;
                    _fisEntity.CepTelefonu = _cepTelefonu;
                    _fisEntity.BankaId = _bankaId;
                    _fisEntity.Il = _il;
                    _fisEntity.Ilce = _ilce;
                    _fisEntity.Semt = _semt;
                    _fisEntity.Adres = _adres;
                    _fisEntity.VergiDairesi = _vergiDairesi;
                    _fisEntity.VergiNo = _vergiNo;
                    _fisEntity.Borc = txtTutar.Value;
                    _fisEntity.ToplamTutar = txtTutar.Value;
                    _fisEntity.Tarih = txtTarih.DateTime;
                    _fisEntity.Aciklama = txtAciklama.Text;
                    bankaEntity.FisKodu = txtFisKodu.Text;
                    bankaEntity.Hareket = "Banka Çıkış";
                    bankaEntity.BankaId = Convert.ToInt32(_bankaId);
                    bankaEntity.CariId = _cariId;
                    bankaEntity.Tarih = txtTarih.DateTime;
                    bankaEntity.Tutar = txtTutar.Value;
                    bankaEntity.Aciklama = txtAciklama.Text;
                    bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                    fisDAL.AddOrUpdate(context, _fisEntity);
                    context.BankaHareketleri.Load();
                    context.fisler.Load();
                    context.SaveChanges();
                    temizle();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilgileri Kontrol Ediniz");

                }

            }
            else if (cmbIslemTuru.SelectedIndex == 4)
            {
                //try
                // {
                _fisEntity.FisKodu = txtFisKodu.Text;
                _fisEntity.FisTuru = cmbIslemTuru.Text;
                _fisEntity.Alacak = txtTutar.Value;
                _fisEntity.ToplamTutar = txtTutar.Value;
                _fisEntity.BankaId = _bankaId;
                _fisEntity.Tarih = txtTarih.DateTime;
                kasahareketEntity.FisKodu = txtFisKodu.Text;
                kasahareketEntity.Hareket = "Kasa Çıkış";
                kasahareketEntity.KasaId = __kasaId;
                kasahareketEntity.OdemeTuruId = 1;
                kasahareketEntity.Tarih = txtTarih.DateTime;
                kasahareketEntity.Tutar = txtTutar.Value;
                bankaEntity.FisKodu = txtFisKodu.Text;
                bankaEntity.Hareket = "Banka Giriş";
                bankaEntity.Tarih = txtTarih.DateTime;
                bankaEntity.Tutar = txtTutar.Value;
                bankaEntity.Aciklama = txtAciklama.Text;
                kasaHareketDAL.AddOrUpdate(context, kasahareketEntity);
                bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                fisDAL.AddOrUpdate(context, _fisEntity);
                context.KasaHareketleri.Load();
                context.BankaHareketleri.Load();
                context.fisler.Load();
                context.SaveChanges();
                temizle();
                //   }
                // catch (Exception)
                // {

                // MessageBox.Show("Bilgileri Kontrol Ediniz");
                // }

            }
            else if (cmbIslemTuru.SelectedIndex == 5)
            {
                try
                {

                    _fisEntity.FisKodu = txtFisKodu.Text;
                    _fisEntity.FisTuru = cmbIslemTuru.Text;
                    _fisEntity.Borc = txtTutar.Value;
                    _fisEntity.ToplamTutar = txtTutar.Value;
                    _fisEntity.Tarih = txtTarih.DateTime;
                    _fisEntity.BankaId = _bankaId;
                    kasahareketEntity.FisKodu = txtFisKodu.Text;
                    kasahareketEntity.Hareket = "Kasa Giriş";
                    kasahareketEntity.KasaId = __kasaId;
                    kasahareketEntity.Tarih = txtTarih.DateTime;
                    kasahareketEntity.OdemeTuruId = 1;
                    kasahareketEntity.Tutar = txtTutar.Value;
                    bankaEntity.FisKodu = txtFisKodu.Text;
                    bankaEntity.Hareket = "Banka Çıkış";
                    bankaEntity.Tarih = txtTarih.DateTime;
                    bankaEntity.Tutar = txtTutar.Value;
                    bankaEntity.Aciklama = txtAciklama.Text;
                    kasaHareketDAL.AddOrUpdate(context, kasahareketEntity);
                    bankaHareketDAL.AddOrUpdate(context, bankaEntity);
                    fisDAL.AddOrUpdate(context, _fisEntity);
                    context.KasaHareketleri.Load();
                    context.BankaHareketleri.Load();
                    context.fisler.Load();
                    context.SaveChanges();
                    temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgileri Kontrol Ediniz");
                }


            }
            this.Close();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 4)
            {
                lblCariAdi.Text = "Kasa Adı :";

            }
            else if (cmbIslemTuru.SelectedIndex == 5)
            {
                lblCariAdi.Text = "Kasa Adı :";
            }
            else
            {
                lblCariAdi.Text = "Cari Adı :";
            }
        }
    }
}