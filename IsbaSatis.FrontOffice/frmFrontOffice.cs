using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tables.Other_Tables;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Stoklar;
using IsbaSatis.BackOffice.Depolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsbaSatis.BackOffice.Cari;
using IsbaSatis.BackOffice.Fişler;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using IsbaSatis.Raporlar.Fatura_Ve_Fiş;
using DevExpress.Utils;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using IsbaSatis.Admin;
using System.Runtime.InteropServices;
using IsbaSatis.BackOffice.Kasalar;

namespace IsbaSatis.FrontOffice
{
    public partial class frmFrontOffice : DevExpress.XtraEditors.XtraForm
    {

        IsbaSatisContext context;
        FisDAL fisDAL = new FisDAL();
        CodeNumara fisNo = new CodeNumara();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        KasaHareketDAL KasaHareketDAL = new KasaHareketDAL();
        CariDAL cariDAL = new CariDAL();
        ExchangeTool Doviz = new ExchangeTool();
        Fis _fisentity = new Fis();
        StokHareket _stokhareketentity = new StokHareket();
        CodeTool fisKoduOlustur;
        CariBakiye entityBakiye = new CariBakiye();
        private decimal eskifiyat = 0;
        private bool TekParca = false;
        private int odemeTuruId;
        int BekleyenSatisId = 0;
        private int cagirilanSatisId = -1;


        List<BekleyenSatis> _bekleyenSatis = new List<BekleyenSatis>();
        Nullable<int> _cariId;
        public frmFrontOffice()
        {
            InitializeComponent();
            frmKullaniciGiris form = new frmKullaniciGiris();
            form.ShowDialog();
            context = new IsbaSatisContext();
            fisKoduOlustur = new CodeTool(this, CodeTool.Table.Fis,context);
            context.Stoklar.Load();
            context.Depolar.Load();
            //context.Kasalar.Load();
            //context.Cariler.Load();
            gridcontStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridcontKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridLookUpEdit1.Properties.DataSource = Doviz.DovizKuruCek();
            KodUret();
            txtIslem.Text = "SATIŞ";
            toplamlar();
            fisKoduOlustur.BarButonOlustur();
            txtBarkod.Focus();

            foreach (var hizliSatisGrup in context.hizliSatisGruplari.ToList())
            {
                XtraTabPage page = new XtraTabPage { Name = hizliSatisGrup.Id.ToString(), Text = hizliSatisGrup.GrupAdi };
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                panel.AutoScroll = true;
                page.Controls.Add(panel);
                foreach (var hizlisatis in context.HizliSatislar.Where(c => c.GrupId == hizliSatisGrup.Id).ToList())
                {
                    SimpleButton buton = new SimpleButton
                    {
                        Name = hizlisatis.Barkod,
                        Text = hizlisatis.UrunAdi,
                        Height = 95,
                        Width = 95
                       
                    };
                    buton.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
                    buton.Click += HizliSatis_Click;
                    panel.Controls.Add(buton);
                }
                xtraTabControl1.TabPages.Add(page);
            }
            var AcikHesapbuton = new SimpleButton
            {
                Name = "AcikHesap",
                Text = "Açık Hesap",
                Height = 43,
                Width = 120,
            };
            AcikHesapbuton.Click += AcikHesap_Click;
            flowOdemeTur.Controls.Add(AcikHesapbuton);
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
                Checked = true
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    Tag = item.Id,
                    GroupIndex = 1,
                    Height = 43,
                    Width = 120,
                    Checked = false
                };
                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }

        }

        void KodUret()
        {
            Random rastgele = new Random();
            int[] sayiUret = new int[6];
            sayiUret[0] = rastgele.Next(1, 9);
            sayiUret[1] = rastgele.Next(1, 9);
            sayiUret[2] = rastgele.Next(33, 46);
            sayiUret[3] = rastgele.Next(65, 91);
            sayiUret[4] = rastgele.Next(65, 91);
            sayiUret[5] = rastgele.Next(65, 91);
            char[] harfUret = new char[4];
            harfUret[0] = Convert.ToChar(sayiUret[2]);
            harfUret[1] = Convert.ToChar(sayiUret[3]);
            harfUret[2] = Convert.ToChar(sayiUret[4]);
            harfUret[3] = Convert.ToChar(sayiUret[5]);
            string olusturulanSifre;
            olusturulanSifre = harfUret[1].ToString().ToUpper() + sayiUret[0].ToString() + harfUret[0].ToString() + sayiUret[1].ToString() + harfUret[2].ToString().ToLower() + harfUret[3].ToString().ToUpper();
            txtKod.Text = olusturulanSifre;
        }
        private void AcikHesap_Click(object sender, EventArgs e)
        {
            odemeTuruId = -1;

            radialYazdir.ShowPopup(MousePosition);
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
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Tag);

            }

        }
        private void BekleyenSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            BekleyenSatisYukle(Convert.ToInt32(buton.Name));
            KodUret();

        }
        private void BekleyenSatisYukle(int id)
        {
            if (cagirilanSatisId == -1 && gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Bekleyen Satışı Çağırmadan Önce  Mevcutta Olan Satışı Beklemeye Almak İstermisiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SatisBeklet();
                }
            }
            FisTemizle();
            var SatisBilgisi = _bekleyenSatis.SingleOrDefault(c => c.Id == id);
            _fisentity.CariId = SatisBilgisi.BekeleyenFis.CariId;
            var cariBilgi = context.Cariler.SingleOrDefault(c => c.Id == _fisentity.CariId);

            if (cariBilgi != null)
            {
                entityBakiye = cariDAL.CariBakiyesi(context, Convert.ToInt32(SatisBilgisi.BekeleyenFis.CariId));
                lblCariKodu.Text = cariBilgi.CariKodu;
                lblCariAdi.Text = cariBilgi.CariAdi;
                lblAlcak.Text = entityBakiye.Alcak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }

            _fisentity.PlasiyerId = SatisBilgisi.BekeleyenFis.PlasiyerId;
            var personelBilgi = context.Personeller.SingleOrDefault(c => c.Id == _fisentity.PlasiyerId);
            if (personelBilgi != null)
            {
                var buton = (CheckButton)flowPersonel.Controls.Find(personelBilgi.PersonelKodu, false).SingleOrDefault();
                buton.Checked = true;

            }
            else
            {
                var buton = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();
                buton.Checked = true;
            }
            txtFaturaUnvani.Text = SatisBilgisi.BekeleyenFis.FaturaUnvani;
            txtBelgeNo.Text = SatisBilgisi.BekeleyenFis.BelgeNo;
            txtVargiDairesi.Text = SatisBilgisi.BekeleyenFis.VergiDairesi;
            txtAciklama.Text = SatisBilgisi.BekeleyenFis.Aciklama;
            txtVergiNo.Text = SatisBilgisi.BekeleyenFis.VergiNo;
            txtCepTelefonu.Text = SatisBilgisi.BekeleyenFis.CepTelefonu;
            txtIl.Text = SatisBilgisi.BekeleyenFis.Il;
            txtIlce.Text = SatisBilgisi.BekeleyenFis.Ilce;
            txtSemt.Text = SatisBilgisi.BekeleyenFis.Semt;
            txtAdres.Text = SatisBilgisi.BekeleyenFis.Adres;
            txtGenelToplam.Value = Convert.ToDecimal(SatisBilgisi.BekeleyenFis.ToplamTutar);
            txtIskontoOran.Value = Convert.ToDecimal(SatisBilgisi.BekeleyenFis.IskontoOrani);
            txtIskontoToplam.Value = Convert.ToDecimal(SatisBilgisi.BekeleyenFis.IskontoTutar);



            foreach (var item in SatisBilgisi.StokHareketi)
            {
                context.StokHareketleri.Local.Add(item);
            }
            foreach (var item in SatisBilgisi.KasaHareketi)
            {
                context.KasaHareketleri.Local.Add(item);
            }
            cagirilanSatisId = id;
            toplamlar();
            OdenenTutarGuncelle();



        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            string kasaAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            if (chkOdemeBol.Checked)
            {
                if (txtOdemesiGereken.Value == 0)
                {
                    MessageBox.Show("Ödenmesi Gereken Tutar Zaten Ödenmiş Durumda");
                }
                else
                {
                    frmOdemeEkrani form = new frmOdemeEkrani(Convert.ToInt32(buton.Tag), txtOdemesiGereken.Value);
                    form.ShowDialog();
                    if (form.entity != null)
                    {

                        KasaHareketDAL.AddOrUpdate(context, form.entity);
                        OdenenTutarGuncelle();
                    }
                }
            }
            else
            {
                odemeTuruId = Convert.ToInt32(buton.Tag);
                TekParca = true;
                radialYazdir.ShowPopup(MousePosition);



            }
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();

            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtOdemesiGereken.Value = txtGenelToplam.Value - txtOdenenTutar.Value;


        }
        private void HizliSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            Isbasatis.Entities.Tables.Stok entity;
            entity = context.Stoklar.SingleOrDefault(c => c.Barkod == buton.Name);
            if (entity != null)
            {
                if (StokKontrol(entity))
                {
                    stokHareketDAL.AddOrUpdate(context, StokSec(entity));
                    toplamlar();
                }
            }
            else
            {
                MessageBox.Show("Aradığınız Barkod Numarası Stoklar Arasında Bulunamadı");
            }
            txtMiktar.Value = 1;


        }


        private void btnUrunBu_Click(object sender, EventArgs e)
        {

            frmStokSec frm = new frmStokSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                if (StokKontrol(frm.secilen.First()))
                {
                    stokHareketDAL.AddOrUpdate(context, StokSec(frm.secilen.SingleOrDefault()));
                    toplamlar();
                }

            }

        }
        private bool StokKontrol(Stok entity)
        {
            var MevcutStok = context.StokHareketleri.Where(c => c.Hareket == "Stok Giriş" && c.Id == entity.Id).Sum(c => c.Miktar) ?? 0
                  - context.StokHareketleri.Where(c => c.Hareket == "Stok Çıkış" && c.Id == entity.Id).Sum(c => c.Miktar) ?? 0;
            if (txtIslem.Text == "SATIŞ" && entity.MinStokMiktari > MevcutStok - (txtMiktar.Value + context.StokHareketleri.Local.Where(c => c.StokId == entity.Id).Sum(c => c.Miktar)))
            {
                MessageBox.Show("Satışını Yapmak İstediğiniz Stok Minimum Düzeydedir Lütfen Satış Yapabilmek İçin Stok Miktarını yükseltmelisiniz");
                return false;
            }
            else
            {
                return true;
            }
        }
        private StokHareket StokSec(Isbasatis.Entities.Tables.Stok entity)

        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDAL = new IndirimDAL();
            stokHareket.StokId = entity.Id;

            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            stokHareket.BirimFiyati = _fisentity.FisTuru == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.AlisFiyati = entity.AlisFiyati1;
            stokHareket.AlisFiyati2 = entity.AlisFiyati2;
            stokHareket.AlisFiyati3 = entity.AlisFiyati3;
            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.IndirimOrani = indirimDAL.StokIndirimi(context, entity.StokKodu);
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }

        private void repoDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec frm = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoId, frm.entity.Id);
                context.ChangeTracker.DetectChanges();
            }
        }




        private void CariTemizle()
        {
            lblCariKodu.Text = "--Cari Bilgisi Görüntülenemiyor--";
            lblCariAdi.Text = "--Cari Bilgisi Görüntülenemiyor--";
            _fisentity.CariId = null;
            txtFaturaUnvani.Text = null;
            txtVargiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblRiskLimiti.Text = "";
            lblAlcak.Text = "-Görüntülenemiyor-";
            lblBorc.Text = "-Görüntülenemiyor-";
            lblBakiye.Text = "-Görüntülenemiyor-";
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                toplamlar();
            }
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            frmFisSeriNoGit frm = new frmFisSeriNoGit(Veri, false);
            frm.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, frm.VeriSeriNo);
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Isbasatis.Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = _fisentity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = _fisentity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = _fisentity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void toplamlar()
        {
            gridStokHareket.UpdateSummary();
            txtIskontoToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOran.Value;
            txtGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoToplam.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue);
            txtAraToplam.Value = txtGenelToplam.Value - txtKdvToplam.Value;
            txtParaUstu.Value = txtOdenen.Value - txtGenelToplam.Value;
            txtOdemesiGereken.Value = txtGenelToplam.Value - txtOdenenTutar.Value;
        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                toplamlar();



            }
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Mevcut Satışı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    FisTemizle();

                    context.StokHareketleri.Local.Clear();
                    KodUret();
                }
            }
            else
            {
                MessageBox.Show("Mevcutta Bir İşlem Bulunamadı. ");
            }

        }

        private void btnCarisec_Click_1(object sender, EventArgs e)
        {
            frmCariSec frm = new frmCariSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Isbasatis.Entities.Tables.Cari entity = frm.secilen.FirstOrDefault();
                entityBakiye = cariDAL.CariBakiyesi(context, entity.Id);

                _cariId = entity.Id;
                _fisentity.CariId = entity.Id;
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
                if (entityBakiye.RiskLimiti != 0)
                {
                    lblRiskLimiti.Text = entityBakiye.RiskLimiti.ToString("C2");
                }

                lblAlcak.Text = entityBakiye.Alcak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            CariTemizle();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIade.Checked)
            {
                txtIslem.Text = "İADE";
                txtIslem.BackColor = Color.Red;
            }
            else
            {
                txtIslem.Text = "SATIŞ";
                txtIslem.BackColor = Color.Green;
            }
        }
        private void ParaEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            txtOdenen.Value += ConverterTool.StringToDecimal(buton.Tag.ToString(), ".");
            toplamlar();
        }

        private void txtOdenen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtOdenen.Value = 0;
            toplamlar();
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                txtMiktar.Value = 0;

                string barkod = gridStokHareket.GetFocusedRowCellValue(colBarkod).ToString();
                if (!StokKontrol(context.Stoklar.SingleOrDefault(c => c.Barkod == barkod)))
                {
                    gridStokHareket.SetFocusedRowCellValue(colMiktar, eskifiyat);
                }
                txtMiktar.Value = 1;

            }
            toplamlar();
            OdenenTutarGuncelle();

        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Isbasatis.Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    if (StokKontrol(entity))
                    {
                        stokHareketDAL.AddOrUpdate(context, StokSec(entity));
                        toplamlar();
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod Numarası Stoklar Arasında Bulunamadı");
                }
                txtBarkod.Text = null;
            }
        }

        private void txtIskontoOran_Validated(object sender, EventArgs e)
        {
            toplamlar();
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkOdemeBol_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOdemeBol.Checked)
            {
                navigationFrame1.SelectedPage = navOdeme;
                flowOdemeTur.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = false;
            }
            else
            {
                navigationFrame1.SelectedPage = navStokHareket;
                flowOdemeTur.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = true;
            }
        }
        private void FisKaydet(ReporPrintTool.Belge belge)
        {

            toplamlar();
            OdenenTutarGuncelle();

            string message = null;
            int hata = 0;

            if (gridStokHareket.RowCount == 0)
            {
                message += "Satış Ekranında hiç bir ürün bulunmamaktadır." + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && chkOdemeBol.Checked && String.IsNullOrEmpty(lblCariKodu.Text))
            {
                message += "Herhangi bir Ödeme bulunamadı" + System.Environment.NewLine;
                hata++;
            }
            if (txtKod.Text == "")
            {

                message += "Fiş Kodu Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }

            if (txtOdemesiGereken.Value != 0 && String.IsNullOrEmpty(lblCariKodu.Text) && TekParca == false)
            {
                message += "Ödenmesi Gereken Tutar Ödenmemiş Görünüyor.Ödenmeyen Kısmı Hesaba Aktarmak İçin Cari Seçmeniz Gerekiyor." + System.Environment.NewLine;
                hata++;

            }
            if (!String.IsNullOrEmpty(lblCariKodu.Text) && (entityBakiye.Bakiye - txtOdemesiGereken.Value) < 0 && ((entityBakiye.Bakiye - txtOdemesiGereken.Value) * -1) > entityBakiye.RiskLimiti)
            {
                if (lblRiskLimiti.Text != "")
                {
                    message += "Cari Risk Limiti Aşılıyor. Satış Yapılamaz." + System.Environment.NewLine;
                    hata++;
                }

            }

            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            if (chkOdemeBol.Checked && txtOdemesiGereken.Value != 0)
            {
                if (MessageBox.Show($"Ödemenin {txtOdemesiGereken.Value.ToString("C2")} Tutarındaki Kısmı Açık Hesap Bakiyesi Olarak Kaydedilecektir. Devam Etmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz Üzere İşlem İptal Edildi");
                    return;
                }
            }
            _fisentity.FisTuru = txtIslem.Text == "İADE" ? "Satış İade Faturası" : "Satış Faturası";
            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = DateTime.Now;
                stokVeri.ToplamTutar = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = txtIslem.Text == "İADE" ? "Stok Griş" : "Stok Çıkış";

            }
            foreach (var KasaVeri in context.KasaHareketleri.Local.ToList())
            {
                KasaVeri.Tarih = DateTime.Now;
                KasaVeri.FisKodu = txtKod.Text;
                KasaVeri.Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş";
                KasaVeri.CariId = _cariId;



            }
            _fisentity.FisKodu = txtKod.Text;
            _fisentity.BelgeNo = txtBelgeNo.Text;
            _fisentity.Aciklama = txtAciklama.Text;
            _fisentity.FaturaUnvani = txtFaturaUnvani.Text;
            _fisentity.CepTelefonu = txtCepTelefonu.Text;
            _fisentity.Il = txtIl.Text;
            _fisentity.Ilce = txtIlce.Text;
            _fisentity.Semt = txtSemt.Text;
            _fisentity.Adres = txtAdres.Text;
            _fisentity.VergiDairesi = txtVargiDairesi.Text;
            _fisentity.VergiNo = txtVergiNo.Text;
            _fisentity.ToplamTutar = txtGenelToplam.Value;
            _fisentity.IskontoOrani = txtIskontoOran.Value;
            _fisentity.IskontoTutar = txtIskontoToplam.Value;
            _fisentity.Tarih = DateTime.Now;

            KasaHareketDAL.Save(context);
            fisDAL.AddOrUpdate(context, _fisentity);
            Fis odemeFisi = _fisentity.Clone();
            odemeFisi.FisTuru = "Fİş Ödemesi";
            odemeFisi.FisKodu = fisKoduOlustur.YeniFisOdemeKoduOlustur();
            _fisentity.FisBaglantiKodu = odemeFisi.FisKodu;
            odemeFisi.FisBaglantiKodu = _fisentity.FisKodu;

            odemeFisi.ToplamTutar = TekParca ? txtGenelToplam.Value : txtOdenenTutar.Value;
            if (txtIslem.Text == "SATIŞ")
            {
                _fisentity.Borc = txtGenelToplam.Value;
                odemeFisi.Alacak = TekParca ? txtGenelToplam.Value : txtOdenenTutar.Value;
                odemeFisi.Borc = null;
                _fisentity.Alacak = null;
            }
            else
            {
                _fisentity.Alacak = txtGenelToplam.Value;
                odemeFisi.Borc = TekParca ? txtGenelToplam.Value : txtOdenenTutar.Value;
                odemeFisi.Alacak = null;
                _fisentity.Borc = null;
            }
            fisDAL.AddOrUpdate(context, odemeFisi);

            int kasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa));
            if (!chkOdemeBol.Checked && odemeTuruId != -1)
            {
                KasaHareketDAL.AddOrUpdate(context, new KasaHareket
                {
                    CariId = _cariId,
                    FisKodu = txtKod.Text,
                    Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                    KasaId = kasaId,
                    OdemeTuruId = odemeTuruId,
                    Tarih = DateTime.Now,
                    Tutar = txtGenelToplam.Value
                });
                OdenenTutarGuncelle();
            }
            context.SaveChanges();
            chkOdemeBol.Checked = false;
            radialYazdir.HidePopup();
            switch (belge)
            {
                case ReporPrintTool.Belge.BilgiFisi:
                    ReporPrintTool yazdirBilgiFisi = new ReporPrintTool();
                    rptBilgiFisi bilgiFisi = new rptBilgiFisi(txtKod.Text);
                    yazdirBilgiFisi.RoporYazdir(bilgiFisi, belge);
                    break;
                case ReporPrintTool.Belge.Fatura:
                    ReporPrintTool yazdir = new ReporPrintTool();
                    rptFatura fatura = new rptFatura(txtKod.Text);
                    yazdir.RoporYazdir(fatura, belge);
                    break;

            }
            if (cagirilanSatisId != -1)
            {
                var secilen = _bekleyenSatis.SingleOrDefault(c => c.Id == cagirilanSatisId);
                _bekleyenSatis.Remove(secilen);
                flowBekleyen.Controls.Find(Convert.ToString(cagirilanSatisId), false).SingleOrDefault().Dispose();
                cagirilanSatisId = -1;

            }
            FisTemizle();
            KodUret();
            TekParca = false;

        }
        private void FisTemizle()
        {
            txtKod.Text = null;

            var cikarilacakKayit = context.ChangeTracker.Entries()
                .Where(c => c.Entity is KasaHareket || c.Entity is StokHareket || c.Entity is Fis).ToList();
            foreach (var kayit in cikarilacakKayit)
            {
                context.Entry(kayit.Entity).State = EntityState.Detached;
            }
            _fisentity = new Fis();
            txtIskontoOran.Value = 0;
            CariTemizle();
            toplamlar();
            OdenenTutarGuncelle();
        }

        private void btnIslemBitir_Click(object sender, EventArgs e)
        {
            radialYazdir.ShowPopup(MousePosition);
        }

        private void barbtnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisKaydet(ReporPrintTool.Belge.Fatura);


        }

        private void barbtnBilgiFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisKaydet(ReporPrintTool.Belge.BilgiFisi);

        }

        private void gridStokHareket_ShownEditor(object sender, EventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                eskifiyat = (decimal)gridStokHareket.GetFocusedRowCellValue(colMiktar);
            }
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtDovizTutar.Value = txtGenelToplam.Value / Convert.ToDecimal(gridLookUpEdit1View.GetFocusedRowCellValue(colBanknoteSelling));
            }
            catch (Exception)
            {


            }

        }

        private void btnBeklet_Click(object sender, EventArgs e)
        {
            SatisBeklet();
        }
        private void SatisBeklet()
        {
            int BekleyenId;
            BekleyenSatis satis;
            if (cagirilanSatisId != -1)
            {
                BekleyenId = cagirilanSatisId;
                satis = _bekleyenSatis.SingleOrDefault(c => c.Id == BekleyenId);
                var buton = (SimpleButton)flowBekleyen.Controls.Find(Convert.ToString(BekleyenId), false).SingleOrDefault();
                buton.Text = txtKod.Text + "\n" + txtIslem.Text + "\n" + context.StokHareketleri.Local.Count + " adet ürün eklendi" + "\n" + txtGenelToplam.Value.ToString("C2");

            }
            else
            {
                BekleyenId = BekleyenSatisId;
                satis = new BekleyenSatis();
                satis.BekeleyenFis = new Fis();
                satis.Id = BekleyenId;
                SimpleButton BekleyenButon = new SimpleButton
                {
                    Name = BekleyenSatisId.ToString(),
                    Text = txtKod.Text + "\n" + txtIslem.Text + "\n" + context.StokHareketleri.Local.Count + " adet ürün eklendi" + "\n" + txtGenelToplam.Value.ToString("C2"),
                    Height = 150,
                    Width = flowBekleyen.Width - 5
                };
                BekleyenButon.Click += BekleyenSatis_Click;
                flowBekleyen.Controls.Add(BekleyenButon);
                BekleyenSatisId++;
            }
            satis.BekeleyenFis.CariId = _fisentity.CariId;
            satis.BekeleyenFis.Cari = _fisentity.Cari;
            satis.BekeleyenFis.Aciklama = txtAciklama.Text;
            satis.BekeleyenFis.Adres = txtAdres.Text;
            satis.BekeleyenFis.BelgeNo = txtBelgeNo.Text;
            satis.BekeleyenFis.CepTelefonu = txtCepTelefonu.Text;
            satis.BekeleyenFis.FaturaUnvani = txtFaturaUnvani.Text;
            satis.BekeleyenFis.FisKodu = _fisentity.FisKodu;
            satis.BekeleyenFis.FisTuru = _fisentity.FisTuru;
            satis.BekeleyenFis.Il = txtIl.Text;
            satis.BekeleyenFis.Ilce = txtIlce.Text;
            satis.BekeleyenFis.Semt = txtSemt.Text;
            satis.BekeleyenFis.PlasiyerId = _fisentity.PlasiyerId;
            satis.BekeleyenFis.VergiDairesi = txtVargiDairesi.Text;
            satis.BekeleyenFis.VergiNo = txtVergiNo.Text;
            satis.BekeleyenFis.IskontoOrani = txtIskontoOran.Value;

            satis.StokHareketi = context.StokHareketleri.Local.ToList();
            satis.KasaHareketi = context.KasaHareketleri.Local.ToList();

            CheckButton personelButonYok = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();
            personelButonYok.Checked = true;
            if (cagirilanSatisId == -1)
            {
                _bekleyenSatis.Add(satis);

            }

            cagirilanSatisId = -1;
            FisTemizle();
            KodUret();

        }




        private void simpleButton13_Click(object sender, EventArgs e)
        {

        }

        private void frmFrontOffice_Load(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }

        private void barbtnBelgesiz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisKaydet(ReporPrintTool.Belge.Diger);
        }

        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKasaSec frm = new frmKasaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaId, frm.entity.Id);
                context.ChangeTracker.DetectChanges();

            }
        }

        private void txtIndirimToplam_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
