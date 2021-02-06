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
using Isbasatis.Entities.Context;
using IsbaSatis.BackOffice.Tanım;
using Isbasatis.Entities.Tables.Other_Tables;
using Isbasatis.Entities.Tools;

namespace IsbaSatis.BackOffice.Cari
{
    public partial class frmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Isbasatis.Entities.Tables.Cari _entity;
        private CariDAL cariDAL = new CariDAL();
        private IsbaSatisContext context = new IsbaSatisContext();
        private CodeTool kodolustur;


        public frmCariIslem(Isbasatis.Entities.Tables.Cari entity,bool kopyala=false)
        {
            InitializeComponent();
            kodolustur = new CodeTool(this,CodeTool.Table.Cari,context);
            kodolustur.BarButonOlustur();
            if (kopyala)
            {
                _entity = new Isbasatis.Entities.Tables.Cari();
                _entity.Id = -1;
                _entity.CariKodu = "";
                _entity.Aciklama = entity.Aciklama;
                _entity.Adres = entity.Adres;
                _entity.AlisOzelFiyati = entity.AlisOzelFiyati;
                _entity.CariAdi = entity.CariAdi;
                _entity.CariAltGrubu = entity.CariAltGrubu;
                _entity.CariGrubu = entity.CariGrubu;
                _entity.CariTuru = entity.CariTuru;
                _entity.CepTelefonu = entity.CepTelefonu;
                _entity.Durumu = entity.Durumu;
                _entity.Adres = entity.Adres;
                _entity.Fax = entity.Fax;
                _entity.EMail = entity.EMail;
                _entity.Il = entity.Il;
                _entity.Ilce = entity.Ilce;
                _entity.Semt = entity.Semt;
                _entity.VergiDairesi = entity.VergiDairesi;
                _entity.VergiNo = entity.VergiNo;
                _entity.Web = entity.Web;
                _entity.Telefon = entity.Telefon;
                _entity.SatisOzelFiyati = entity.SatisOzelFiyati;
                _entity.YetkiliKisi = entity.YetkiliKisi;
                _entity.RiskLimiti = entity.RiskLimiti;
                _entity.IskontoOrani = entity.IskontoOrani;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.FaturaUnvani = entity.FaturaUnvani;

            }
            else
            {
                _entity = entity;
            }
            
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbAlisOzelFiyat.DataBindings.Add("Text", _entity, "AlisOzelFiyati", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbSatisOzelFiyati.DataBindings.Add("Text", _entity, "SatisOzelFiyati", false, DataSourceUpdateMode.OnPropertyChanged);

            txtIskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIskontoOrani.DataBindings[0].FormattingEnabled = true;
            txtIskontoOrani.DataBindings[0].FormatString = "'%'0";
            txtIskontoOrani.DataBindings[0].DataSourceNullValue = "0";

            txtRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRiskLimiti.DataBindings[0].FormattingEnabled = true;
            txtRiskLimiti.DataBindings[0].FormatString = "C2";
            txtRiskLimiti.DataBindings[0].DataSourceNullValue = "0";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDAL.AddOrUpdate(context, _entity))
            {
                kodolustur.KodArttirma();
                cariDAL.Save(context);
                this.Close();

            }
        }

        private void btnCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariGrubu);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnCariGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnCariGrubu.Text = null;       
                    break;
            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod1);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnOzelKod1.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod1.Text = null;
                    break;
            }
        }

        private void btnOzelKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod2);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnOzelKod2.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod2.Text = null;
                    break;
            }
        }

        private void btnOzelKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod3);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnOzelKod3.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod3.Text = null;
                    break;
            }
        }

        private void btnOzelKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod4);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnOzelKod4.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod4.Text = null;
                    break;
            }
        }

        private void frmCariIslem_Load(object sender, EventArgs e)
        {
        


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}