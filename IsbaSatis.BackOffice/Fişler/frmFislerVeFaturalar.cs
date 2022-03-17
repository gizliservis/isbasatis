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
using Isbasatis.Entities.Mapping;
using Isbasatis.Entities.Context;
using System.Data.Entity;
using Isbasatis.Entities.Tables;
using IsbaSatis.BackOffice.Stoklar;
using IsbaSatis.BackOffice.Cari;
using IsbaSatis.BackOffice.Depolar;
using IsbaSatis.BackOffice.Kasalar;
using Isbasatis.Entities.Tables.Other_Tables;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Personeller;
using IsbaSatis.Raporlar.Fatura_Ve_Fiş;

namespace IsbaSatis.BackOffice.Fişler
{
    public partial class frmFislerVeFaturalar : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        FisDAL fisDAL = new FisDAL();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        KasaHareketDAL KasaHareketDAL = new KasaHareketDAL();
        PersonelHareketDAL personelHareketDAL = new PersonelHareketDAL();
        CariDAL cariDAL = new CariDAL();
        Fis _fisentity = new Fis();
        FisAyarlari fisAyarlari = new FisAyarlari();
        private CodeTool kodOlustur;
        StokHareket _stokhareketentity = new StokHareket();
        CariBakiye entityBakiye = new CariBakiye();
        CodeNumara odemefis = new CodeNumara();

        private Nullable<int> _cariId;


        public frmFislerVeFaturalar(string fisKodu = null, string fisTuru = null, int? cariId = null, bool siparisFaturalandir = false)
        {
            InitializeComponent();

            kodOlustur = new CodeTool(this, CodeTool.Table.Fis, context);
            kodOlustur.BarButonOlustur();

            context.Stoklar.Load();
            context.Depolar.Load();
            context.Kasalar.Load();
            //context.Cariler.Load();
            if (fisKodu != null)
            {
                _fisentity = context.fisler.SingleOrDefault(c => c.FisKodu == fisKodu);
                if (siparisFaturalandir)
                {
                    _fisentity.FisTuru = "Satış Faturası";
                }
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                if (String.IsNullOrEmpty(_fisentity.DepoAdi) && String.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                }
                else if (String.IsNullOrEmpty(_fisentity.DepoAdi))
                {
                    context.KasaHareketleri.Where(c => c.FisKodu == _fisentity.FisBaglantiKodu).Load();
                }
                else if (String.IsNullOrEmpty(_fisentity.FisBaglantiKodu) && !String.IsNullOrEmpty(_fisentity.DepoAdi))
                {
                    context.StokHareketleri.Where(c => c.FisBaglantiKodu == fisKodu).Load();
                }
                else if (!String.IsNullOrEmpty(_fisentity.DepoAdi))
                {
                    context.StokHareketleri.Where(c => c.FisBaglantiKodu == fisKodu);
                }

                context.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                toggleSwitch1.IsOn = context.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;
                if (_fisentity.CariId != null)
                {
                    var cariBilgi = context.Cariler.SingleOrDefault(c => c.Id == _fisentity.CariId);
                    lblCariKodu.Text = cariBilgi.CariKodu;
                    lblCariAdi.Text = cariBilgi.CariAdi;
                    entityBakiye = this.cariDAL.CariBakiyesi(context, Convert.ToInt32(_fisentity.CariId));
                    lblAlcak.Text = entityBakiye.Alcak.ToString("C2");
                    lblBorc.Text = entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
                }


            }
            else
            {
                _fisentity.FisTuru = fisTuru;
                _fisentity.Tarih = DateTime.Now;
            }
            if (_fisentity.FisTuru == "Depo İrsaliyesi" && _fisentity.DepoIrsaliye == true)
            {
                simpleButton2.Enabled = false;
            }

            lblAlcak.Text = "-Görüntülenemiyor-";
            lblBorc.Text = "-Görüntülenemiyor-";
            lblBakiye.Text = "-Görüntülenemiyor-";
            txtKod.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFisturu.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVargiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIskontoToplam.DataBindings.Add("EditValue", _fisentity, "IskontoTutar", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIskontoOran.DataBindings.Add("EditValue", _fisentity, "IskontoOrani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDepoAdi.DataBindings.Add("Text", _fisentity, "DepoAdi", false, DataSourceUpdateMode.OnPropertyChanged);

            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year + 5; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();

            gridcontStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridcontKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridcontPersonelHareket.DataSource = context.PersonelHareketleri.Local.ToBindingList();
            FisAyar();
            toplamlar();
            OdenenTutarGuncelle();
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 43,
                    Width = 120,
                };
                buton.Click += OdemeEkle_Click;
                flowOdemeTur.Controls.Add(buton);
            }
            var PersonelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 43,
                Width = 120,
                Checked = _fisentity.PlasiyerId == null
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.Id.ToString(),
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 43,
                    Width = 120,
                    Checked = item.Id == _fisentity.PlasiyerId
                };
                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }

        }
        private void PersonelYukle_Click(object sender, EventArgs e)
        {
            var buton = sender as CheckButton;
            if (buton.Name == "Yok")
            {
                _fisentity.PlasiyerId = null;

            }
            else
            {
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Name);

            }

        }



        private void FisAyar()
        {

            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":

                    fisAyarlari.StokHareketi = "Stok Giriş";
                    fisAyarlari.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.ImageOptions.ImageIndex = 0;
                    navPersonelIslem.Dispose();
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = true;
                    fisAyarlari.BakiyeTuru = "Alacak";
                    lblBaslik.Text = "Alış Faturası";

                    break;
                case "Satış Faturası":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    fisAyarlari.KasaHareketi = "Kasa Giriş";
                    navPersonelIslem.Dispose();
                    lblBaslik.ImageOptions.ImageIndex = 1;
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = true;
                    fisAyarlari.BakiyeTuru = "Borç";
                    lblBaslik.Text = "Satış Faturası";

                    break;
                case "Toptan Satış Faturası":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    fisAyarlari.KasaHareketi = "Kasa Giriş";
                    navPersonelIslem.Dispose();
                    lblBaslik.ImageOptions.ImageIndex = 2;
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = true;
                    fisAyarlari.BakiyeTuru = "Borç";
                    lblBaslik.Text = "Toptan Satış Faturası";
                    break;
                case "Alış İade Faturası":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    fisAyarlari.KasaHareketi = "Kasa Giriş";
                    navPersonelIslem.Dispose();
                    lblBaslik.ImageOptions.ImageIndex = 4;
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = true;
                    fisAyarlari.BakiyeTuru = "Borç";
                    lblBaslik.Text = "Alış İade Faturası";
                    break;
                case "Satış İade Faturası":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    fisAyarlari.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.ImageOptions.ImageIndex = 3;
                    navPersonelIslem.Dispose();
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = true;
                    fisAyarlari.BakiyeTuru = "Alacak";
                    lblBaslik.Text = "Satış İade Faturası";
                    break;
                case "Sayım Fazlası Fişi":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 6;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Sayım Fazlası Fişi";

                    break;
                case "Sayım Eksiği Fişi":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 5;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Sayım Eksiği Fişi";

                    break;
                case "Stok Devir Fişi":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 7;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Stok Devir Fişi";

                    break;
                case "Tahsilat Fişi":
                    fisAyarlari.KasaHareketi = "Kasa Giriş";
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = false;
                    fisAyarlari.BakiyeTuru = "Alacak";
                    navigationPane1.SelectedPage = navOdemeEkrani;
                    navPersonelIslem.Dispose();
                    kapat();
                    alankapa();
                    grpToplam.Height = 70;
                    navSatisEkrani.Dispose();
                    break;
                case "Ödeme Fişi":
                    fisAyarlari.KasaHareketi = "Kasa Çıkış";
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = false;
                    fisAyarlari.BakiyeTuru = "Borç";
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    alankapa();
                    grpToplam.Height = 70;
                    navigationPane1.SelectedPage = navOdemeEkrani;
                    break;
                //bu kısma sonra bakılacak
                case "Cari Devir Fişi":
                    fisAyarlari.KasaHareketi = "Kasa Giriş";
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = false;
                    panelCariDevir.Visible = true;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    alankapa();
                    grpToplam.Height = 70;
                    navigationPane1.SelectedPage = navOdemeEkrani;
                    break;
                case "Hakediş Fişi":
                    fisAyarlari.KasaHareketi = "Kasa Çıkış";
                    fisAyarlari.OdemeEkrani = true;
                    fisAyarlari.SatisEkrani = false;
                    panelCariDevir.Visible = false;
                    navCariBilgi.Dispose();
                    navigationPage1.Dispose();
                    navSatisEkrani.Dispose();
                    alankapa();
                    navigationPane1.SelectedPage = navPersonelIslem;
                    break;
                case "Sipariş Fişi(Alınan)":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 9;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Sipariş Fişi(Alınan)";
                    break;
                case "Sipariş Fişi(Verilen)":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 8;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Sipariş Fişi(Verilen)";
                    break;
                case "Teklif Fişi(Alınan)":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 9;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Teklif Fişi(Alınan)";
                    break;
                case "Teklif Fişi(Verilen)":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 8;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Sipariş Fişi(Verilen)";
                    break;
                case "İrsaliye Fişi(Alınan)":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 9;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Teklif Fişi(Alınan)";
                    break;
                case "İrsaliye Fişi(Verilen)":
                    fisAyarlari.StokHareketi = "Stok Giriş";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 8;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "İrsaliye Fişi(Verilen)";
                    break;

                case "Depo İrsaliyesi":
                    fisAyarlari.StokHareketi = "Stok Çıkış";
                    fisAyarlari.StokHareketiIki = "Stok Giriş";
                    panelDepoTransfer.Visible = true;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    kapat();
                    lblBaslik.ImageOptions.ImageIndex = 8;
                    fisAyarlari.OdemeEkrani = false;
                    fisAyarlari.SatisEkrani = true;
                    lblBaslik.Text = "Depo İrsaliyesi";

                    break;
            }
        }

        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (fisAyarlari.SatisEkrani == false && txtFisturu.Text != "Hakediş Fişi")
            {
                frmOdemeEkrani form = new frmOdemeEkrani(Convert.ToInt32(buton.Tag));
                form.ShowDialog();
                if (form.entity != null)
                {
                    KasaHareketDAL.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }

            }
            else
            {
                if (txtOdemesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.");
                }
                else
                {
                    if (txtFisturu.Text != "Hakediş Fişi")
                    {
                        KasaHareket entityKasaHareket = new KasaHareket
                        {
                            OdemeTuruId = Convert.ToInt32(buton.Tag),
                            KasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa)),
                            Tarih = DateTime.Now,
                            Tutar = txtOdemesiGereken.Value
                        };
                        KasaHareketDAL.AddOrUpdate(context, entityKasaHareket);
                        OdenenTutarGuncelle();
                    }
                    else
                    {
                        for (int i = 0; i < gridPersonelHareket.RowCount; i++)
                        {
                            KasaHareket entityKasaHareket = new KasaHareket
                            {
                                //burayı kontrol et sıkıntı olacak
                                CariId = _cariId,
                                OdemeTuruId = Convert.ToInt32(buton.Tag),
                                Tarih = DateTime.Now,
                                Tutar = Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colOdenecekTutar)),
                                Aciklama = $"{gridPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()} || Aylık Maaş : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colAylikMaasi)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colPrimTutari)).ToString("C2")}"
                            };
                            KasaHareketDAL.AddOrUpdate(context, entityKasaHareket);

                        }
                        OdenenTutarGuncelle();
                    }

                }
            }



        }
        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            if (fisAyarlari.SatisEkrani || _fisentity.FisTuru == "Hakediş Fişi")
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdemesiGereken.Value = txtGenelToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }

        }

        private void frmFislerVeFaturalar_Load(object sender, EventArgs e)
        {
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis, context);
            kodOlustur.BarButonOlustur();
        }
        private StokHareket StokSec(Isbasatis.Entities.Tables.Stok entity)

        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDAL = new IndirimDAL();
            stokHareket.StokId = entity.Id;
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            stokHareket.BirimFiyati = new[] { "Alış Faturası", "Alış İade Faturası" }.Contains(txtFisturu.Text) ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.AlisFiyati2 = entity.AlisFiyati2;
            stokHareket.AlisFiyati3 = entity.AlisFiyati3;
            stokHareket.AlisFiyati = entity.AlisFiyati1;

            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.IndirimOrani = indirimDAL.StokIndirimi(context, entity.StokKodu);
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            frmStokSec frm = new frmStokSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                stokHareketDAL.AddOrUpdate(context, StokSec(frm.secilen.First()));
                toplamlar();
            }

        }
        private void kapat()
        {
            labelControl18.Visible = false;
            labelControl19.Visible = false;
            labelControl20.Visible = false;
            txtOdenenTutar.Visible = false;
            txtOdemesiGereken.Visible = false;
            txtAcikHesap.Visible = false;
        }
        private void alankapa()
        {
            labelControl21.Visible = false;
            labelControl22.Visible = false;
            labelControl23.Visible = false;
            labelControl24.Visible = false;
            txtIndirimToplam.Visible = false;
            txtIskontoOran.Visible = false;
            txtIskontoToplam.Visible = false;
            txtKdvToplam.Visible = false;
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Isbasatis.Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    stokHareketDAL.AddOrUpdate(context, StokSec(entity));
                    toplamlar();
                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod Numarası Stoklar Arasında Bulunamadı");
                }
                txtBarkod.Text = null;
            }
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            frmCariSec frm = new frmCariSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Isbasatis.Entities.Tables.Cari entity = frm.secilen.FirstOrDefault();
                entityBakiye = this.cariDAL.CariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisentity.CariId = _cariId;
                lblCariKodu.Text = entity.CariKodu;
                lblCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVargiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlcak.Text = entityBakiye.Alcak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _cariId = null;
            _fisentity.CariId = null;
            lblCariKodu.Text = null;
            lblCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVargiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlcak.Text = "--Bilgi Yok--";
            lblBorc.Text = "--Bilgi Yok--";
            lblBakiye.Text = "--Bilgi Yok--";
        }

        private void toplamlar()
        {
            gridStokHareket.UpdateSummary();
            gridPersonelHareket.UpdateSummary();
            txtIskontoToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOran.Value;
            if (_fisentity.FisTuru == "Hakediş Fişi")
            {
                txtGenelToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            }
            else
            {
                txtGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoToplam.Value;
            }

            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue);
            txtOdemesiGereken.Value = txtGenelToplam.Value - txtOdenenTutar.Value;
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            toplamlar();
        }

        private void txtIskontoOran_Validated(object sender, EventArgs e)
        {
            toplamlar();
        }

        private void repoDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec frm = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoId, frm.entity.Id);
                context.ChangeTracker.DetectChanges();
                gridStokHareket.RefreshRow(gridStokHareket.FocusedRowHandle);
            }
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Isbasatis.Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = txtFisturu.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisturu.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisturu.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            frmFisSeriNoGit frm = new frmFisSeriNoGit(Veri);
            frm.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, frm.VeriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                toplamlar();



            }
        }

        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKasaSec frm = new frmKasaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaId, frm.entity.Id);
                context.ChangeTracker.DetectChanges();
                gridKasaHareket.RefreshRow(gridKasaHareket.FocusedRowHandle);
            }
        }

        private void repoKHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (toggleSwitch1.IsOn == true && txtFisturu.Text == "Cari Devir Fişi")
            {
                fisAyarlari.KasaHareketi = "Kasa Çıkış";
                fisAyarlari.BakiyeTuru = "Borç";

            }
            else if (toggleSwitch1.IsOn == false && txtFisturu.Text == "Cari Devir Fişi")
            {
                fisAyarlari.KasaHareketi = "Kasa Giriş";
                fisAyarlari.BakiyeTuru = "Alacak";

            }




            string message = null;
            int hata = 0;
            if (gridStokHareket.RowCount == 0 && fisAyarlari.SatisEkrani == true)
            {
                message += "Satış Ekranında hiç bir ürün bulunmamaktadır." + System.Environment.NewLine;
                hata++;
            }
            if (_fisentity.CariId == null && fisAyarlari.SatisEkrani == false && txtFisturu.Text != "Hakediş Fişi")
            {
                message += txtFisturu.Text + "Türünde Cari Seçimi Zorunludur" + System.Environment.NewLine;
                hata++;
            }
            if (gridKasaHareket.RowCount == 0 && fisAyarlari.SatisEkrani == false && txtFisturu.Text != "Hakediş Fişi")
            {
                message += "Herhangi bir Ödeme bulunamadı" + System.Environment.NewLine;
                hata++;
            }
            if (txtKod.Text == "")
            {
                message += "Fiş Kodu Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (txtOdemesiGereken.Value != 0 && fisAyarlari.OdemeEkrani == true && String.IsNullOrEmpty(lblCariKodu.Text) && txtFisturu.Text != "Hakediş Fişi")
            {
                message += "Ödenmesi Gereken Tutar Ödenmemiş Görünüyor.Ödenmeyen Kısmı Hesaba Aktarmak İçin Cari Seçmeniz Gerekiyor." + System.Environment.NewLine;
                hata++;

            }
            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            if (txtOdemesiGereken.Value != 0 && fisAyarlari.OdemeEkrani == true)
            {
                if (MessageBox.Show($"Ödemenin {txtOdemesiGereken.Value.ToString("C2")} Tutarındaki Kısmı Açık Hesap Bakiyesi Olarak Kaydedilecektir. Devam Etmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz Üzere İşlem İptal Edildi");
                    return;
                }
            }

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(cmbTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = fisAyarlari.StokHareketi;
                stokVeri.ToplamTutar = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue);
                stokVeri.Siparis = txtFisturu.Text.Contains("Sipariş Fişi")
                    ? stokVeri.Siparis = true
                    : stokVeri.Siparis = false;
                stokVeri.Siparis = txtFisturu.Text.Contains("Teklif Fişi")
                   ? stokVeri.Teklif = true
                   : stokVeri.Teklif = false;
                stokVeri.Irsaliye = txtFisturu.Text.Contains("İrsaliye Fişi")
                   ? stokVeri.Irsaliye = true
                   : stokVeri.Irsaliye = false;
                stokVeri.Irsaliye = txtFisturu.Text.Contains("Depo İrsaliyesi")
                   ? stokVeri.Irsaliye = true
                   : stokVeri.Irsaliye = false;


            }
            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
            }


            if (fisAyarlari.BakiyeTuru == "Borç")
            {
                _fisentity.Borc = txtGenelToplam.Value;
            }
            else if (fisAyarlari.BakiyeTuru == "Alacak")

            {
                _fisentity.Alacak = txtGenelToplam.Value;
            }

            if (txtFisturu.Text == "Depo İrsaliyesi")
            {
                _fisentity.DepoIrsaliye = true;
                _fisentity.DepoAdi = txtDepoAdi.Text;
            }
            _fisentity.ToplamTutar = txtGenelToplam.Value;
            _fisentity.IskontoOrani = txtIskontoOran.Value;
            _fisentity.IskontoTutar = txtIskontoToplam.Value;
            fisDAL.AddOrUpdate(context, _fisentity);




            if (fisAyarlari.OdemeEkrani)
            {
                Fis fisOdeme = new Fis();
                if (String.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    fisOdeme = _fisentity.Clone();
                    fisOdeme.FisTuru = "Fiş Ödemesi";
                    fisOdeme.Id = -1;
                    fisOdeme.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                    fisOdeme.FisBaglantiKodu = _fisentity.FisKodu;

                }
                else
                {
                    fisOdeme = context.fisler.SingleOrDefault(c => c.FisKodu == _fisentity.FisBaglantiKodu);
                }
                _fisentity.FisBaglantiKodu = fisOdeme.FisKodu;

                if (fisAyarlari.BakiyeTuru == "Borç")
                {
                    fisOdeme.Alacak = txtOdenenTutar.Value;
                    fisOdeme.Borc = null;
                }
                else if (fisAyarlari.BakiyeTuru == "Alacak")
                {
                    fisOdeme.Borc = txtOdenenTutar.Value;
                    fisOdeme.Alacak = null;
                }
                foreach (var KasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    KasaVeri.Tarih = KasaVeri.Tarih == null ? Convert.ToDateTime(cmbTarih.DateTime) : Convert.ToDateTime(KasaVeri.Tarih);
                    KasaVeri.FisKodu = fisOdeme.FisKodu;
                    KasaVeri.Hareket = fisAyarlari.KasaHareketi;
                    if (txtFisturu.Text != "Hakediş Fişi")
                    {
                        KasaVeri.CariId = _cariId;

                    }
                }
                fisOdeme.ToplamTutar = txtOdenenTutar.Value;
                fisDAL.AddOrUpdate(context, fisOdeme);
            }
            kodOlustur.KodArttirma();
            context.SaveChanges();

            if (txtFisturu.Text == "Depo İrsaliyesi")
            {
                StokHareket stkhrk = new StokHareket();

                if (String.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    foreach (var stok in context.StokHareketleri.Local.ToList())
                    {
                        stkhrk = _stokhareketentity.clone();
                        stkhrk.Tarih = cmbTarih.DateTime;
                        stkhrk.Hareket = fisAyarlari.StokHareketiIki;
                        stkhrk.Id = -1;
                        stkhrk.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                        stkhrk.FisBaglantiKodu = txtKod.Text;
                        stkhrk.DepoId = Convert.ToInt32(txtDepoId.Text);
                        stkhrk.StokId = stok.StokId;
                        stkhrk.Miktar = stok.Miktar;
                        stkhrk.Kdv = stok.Kdv;
                        stkhrk.BirimFiyati = stok.BirimFiyati;
                        stkhrk.IndirimOrani = stok.IndirimOrani;
                        stkhrk.SeriNo = stok.SeriNo;
                        stkhrk.Irsaliye = true;
                        stkhrk.ToplamTutar = txtGenelToplam.Value;
                        stokHareketDAL.AddOrUpdate(context, stkhrk);
                        context.SaveChanges();
                    }
                }
                else
                {
                    foreach (var item in context.fisler.Local.ToList())
                    {

                        stkhrk = context.StokHareketleri.SingleOrDefault(c => c.FisBaglantiKodu == item.FisKodu);
                        _fisentity.FisKodu = stkhrk.FisBaglantiKodu;
                        stokHareketDAL.AddOrUpdate(context, stkhrk);
                        context.SaveChanges();
                    }



                }




                //foreach (var stokVeri in context.StokHareketleri.Local.ToList())
                //{
                //    stokVeri.Tarih = stokVeri.Tarih == null
                //        ? Convert.ToDateTime(cmbTarih.DateTime)
                //        : Convert.ToDateTime(stokVeri.Tarih);
                //    stokVeri.FisKodu = txtKod.Text;
                //    stokVeri.Hareket = fisAyarlari.StokHareketiIki;
                //    stokVeri.DepoId = Convert.ToInt32(txtDepoId.Text);
                //    stokVeri.ToplamTutar = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue);
                //    stokVeri.Irsaliye = txtFisturu.Text.Contains("Depo İrsaliyesi")
                //       ? stokVeri.Irsaliye = true
                //       : stokVeri.Irsaliye = false;

                // }

                //  context.SaveChanges();
            }

            if (txtFisturu.Text == "Alış Faturası" && txtFisturu.Text == "Satış Faturası" && txtFisturu.Text == "Toptan Satış Faturası" && txtFisturu.Text == "Alış İade Faturası" && txtFisturu.Text == "Satış İade Faturası")
            {
                if (MessageBox.Show("Faturayı Yazdırmak İstermisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReporPrintTool yazdir = new ReporPrintTool();
                    rptFatura fatura = new rptFatura(txtKod.Text);
                    yazdir.RoporYazdir(fatura, ReporPrintTool.Belge.Fatura);
                }
            }


            this.Close();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Satış Ekranına Eklenmiş Ürünler var.Bu işlemi iptal edip formu kapatmak istediğinize eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {




        }

        private void btnPersonelBul_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            frmPersonelSec frm = new frmPersonelSec(time);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemHareket in frm.secilen.ToList())
                {
                    if (context.PersonelHareketleri.Local.Count(c => c.Donemi == time && c.PersonelKodu == itemHareket.PersonelKodu) == 0)
                    {
                        personelHareketDAL.AddOrUpdate(context, itemHareket);
                    }


                }
                toplamlar();

            }
        }

        private void btnFaturaYazdir_Click(object sender, EventArgs e)
        {

            ReporPrintTool yazdir = new ReporPrintTool();
            rptFatura fatura = new rptFatura(txtKod.Text);
            yazdir.RoporYazdir(fatura, ReporPrintTool.Belge.Fatura);
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec frm = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoId, frm.entity.Id);
                context.ChangeTracker.DetectChanges();
                gridStokHareket.RefreshRow(gridStokHareket.FocusedRowHandle);
            }
        }

        private void repoHedefDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txtDepoAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec form = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            form.ShowDialog();
            if (form.secildi == true)
            {
                txtDepoAdi.Text = form.entity.DepoAdi;
                txtDepoId.Text = form.entity.Id.ToString();
            }
        }
    }
}