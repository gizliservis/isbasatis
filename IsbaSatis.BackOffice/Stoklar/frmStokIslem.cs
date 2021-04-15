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
using Isbasatis.Entities;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Data_Access;
using IsbaSatis.BackOffice.Tanım;
using Isbasatis.Entities.Tables.Other_Tables;
using Isbasatis.Entities.Tools;

namespace IsbaSatis.BackOffice.Stok
{
    public partial class frmStokIslem : DevExpress.XtraEditors.XtraForm
    {
        private Isbasatis.Entities.Tables.Stok _entity;
        private StokDAL stokDAL = new StokDAL();
        private IsbaSatisContext context = new IsbaSatisContext();
        private CodeTool kodOlustur;


        public frmStokIslem(Isbasatis.Entities.Tables.Stok entity)
        {
            InitializeComponent();
            kodOlustur = new CodeTool(this,CodeTool.Table.Stok,context);
            kodOlustur.BarButonOlustur();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBirim.DataBindings.Add("Text", _entity, "Birimi", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            btnModel.DataBindings.Add("Text", _entity, "Modeli", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu", false, DataSourceUpdateMode.OnPropertyChanged);

            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";

            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";

            calcAlisFiyati1.DataBindings.Add("Text", _entity, "AlisFiyati1", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati1.DataBindings[0].FormatString = "C2";

            calcAlisFiyati2.DataBindings.Add("Text", _entity, "AlisFiyati2", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati2.DataBindings[0].FormatString = "C2";

            calcAlisFiyati3.DataBindings.Add("Text", _entity, "AlisFiyati3", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati3.DataBindings[0].FormatString = "C2";

            calcSatisFiyati1.DataBindings.Add("Text", _entity, "SatisFiyati1", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati1.DataBindings[0].FormatString = "C2";

            calcSatisFiyati2.DataBindings.Add("Text", _entity, "SatisFiyati2", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati2.DataBindings[0].FormatString = "C2";

            calcSatisFiyati3.DataBindings.Add("Text", _entity, "SatisFiyati3", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati3.DataBindings[0].FormatString = "C2";

            calcMinStokMiktar.DataBindings.Add("Text", _entity, "MinStokMiktari", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMinStokMiktar.DataBindings[0].FormattingEnabled = true;
            calcMinStokMiktar.DataBindings[0].FormatString = "N3";

            calcMaxStokMiktar.DataBindings.Add("Text", _entity, "MaxStokMiktari", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMaxStokMiktar.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktar.DataBindings[0].FormatString = "N3";

            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDAL.AddOrUpdate(context, _entity))
            {
                kodOlustur.KodArttirma();
                stokDAL.Save(context);
                this.Close();
            }


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Birimi);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnBirim.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnBirim.Text = null;
                    break;
            }
        }

        private void btnStokGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.StokGrubu);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnStokGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnStokGrubu.Text = null;
                    break;
            }
        }

        private void btnStokAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.StokAltGrubu);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnStokAltGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnStokAltGrubu.Text = null;
                    break;
            }
        }

        private void btnMarka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Marka);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnMarka.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnMarka.Text = null;
                    break;
            }
        }

        private void btnModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Modeli);
                    form.ShowDialog();
                    if (form.secildi == true)
                    {
                        btnModel.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnModel.Text = null;
                    break;
            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.OzelKod1);
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
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.OzelKod2);
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
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.OzelKod3);
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
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.OzelKod4);
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

        private void frmStokIslem_Load(object sender, EventArgs e)
        {

        }


    }
}