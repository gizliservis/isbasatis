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
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
using System.Printing;

namespace IsbaSatis.BackOffice.Ayarlar
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        private Isbasatis.Entities.Tables.SirketBilgi _entity;
        IsbaSatisContext context = new IsbaSatisContext();
        SirketBilgiDAL sirketDal = new SirketBilgiDAL();
        DepoDAL depoDAL = new DepoDAL();
        KasaDAL kasaDAL = new KasaDAL();
        public frmAyarlar(Isbasatis.Entities.Tables.SirketBilgi entity)
        {
            InitializeComponent();
            _entity = entity;
            txtSirketKodu.DataBindings.Add("Text", _entity, "SirketKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSirketKisaAdi.DataBindings.Add("Text", _entity, "SirketKisaAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUnvanı.DataBindings.Add("Text", _entity, "SirketUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUlkesi.DataBindings.Add("Text", _entity, "Ulkesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIli.DataBindings.Add("Text", _entity, "Ili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlcesi.DataBindings.Add("Text", _entity, "Ilcesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVD.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdresi.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelNo.DataBindings.Add("Text", _entity, "SirketTelNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "EMail", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYetkilisi.DataBindings.Add("Text", _entity, "YetkiliKisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);


            cmbBilgiFisiYazici.Properties.Items.AddRange(YaziciListesi());
            cmbFaturaYazici.Properties.Items.AddRange(YaziciListesi());
            gridLookUpEdit1.Properties.DataSource = depoDAL.GetAll(context);
            gridLookUpEdit1.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            lookupKasa.Properties.DataSource = kasaDAL.GetAll(context);
            lookupKasa.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            comboBoxEdit1.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
            comboBoxEdit2.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
            cmbFaturaYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
            cmbBilgiFisiYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (sirketDal.AddOrUpdate(context, _entity))
            {
                sirketDal.Save(context);
            }
           
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, gridLookUpEdit1.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici, cmbFaturaYazici.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici, cmbBilgiFisiYazici.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari, comboBoxEdit1.SelectedIndex.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari, comboBoxEdit2.SelectedIndex.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa, lookupKasa.EditValue.ToString());
            SettingsTool.save();
            this.Close();
        }
        private List<string> YaziciListesi()
        {
            return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();
        }
    }
}