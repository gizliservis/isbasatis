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
        IsbaSatisContext context = new IsbaSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        KasaDAL kasaDAL = new KasaDAL();
        public frmAyarlar()
        {
            InitializeComponent();
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
            return new LocalPrintServer().GetPrintQueues().Select(c=>c.Name).ToList();
        }
    }
}