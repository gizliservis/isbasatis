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

namespace IsbaSatis.BackOffice.Personeller
{
    public partial class frmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {
        private Isbasatis.Entities.Tables.Personel _entity;
        private PersonelDAL personelDAL = new PersonelDAL();
        private IsbaSatisContext context = new IsbaSatisContext();
        public bool saved = false;

        public frmPersonelIslem(Isbasatis.Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Calisiyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcKimlikNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIseGirisT.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            txtIstenCikisT.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null, "F");
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
            cmbPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbPrimOrani.DataBindings[0].FormattingEnabled = true;
            cmbPrimOrani.DataBindings[0].FormatString = "'%'0";
            cmbPrimOrani.DataBindings[0].DataSourceNullValue = "0";


            cmbAylikMaas.DataBindings.Add("EditValue", _entity, "AylikMaasi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbAylikMaas.DataBindings[0].FormattingEnabled = true;
            cmbAylikMaas.DataBindings[0].FormatString = "C2";
            cmbAylikMaas.DataBindings[0].DataSourceNullValue = "0";
        }

        private void frmPersonelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDAL.AddOrUpdate(context,_entity))
            {
                saved = true;
                personelDAL.Save(context);
                this.Close();
            }

        }

        private void cmbUnvani_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmTanim frm = new frmTanim(frmTanim.TanimTuru.PersonelUnvan);
            frm.ShowDialog();
            if (frm.secildi)
            {
                cmbUnvani.Text = frm._entity.Tanimi;
            }
        }
    }
}