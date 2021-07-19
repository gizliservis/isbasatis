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


        public frmBankaIslemleri(string fisKodu)
        {
            InitializeComponent();
            if (fisKodu != null)
            {
                _fisEntity = context.fisler.SingleOrDefault(c => c.FisKodu == fisKodu);
            }
            context.Bankalar.Load();
            context.Cariler.Load();

        }

        private void btnCariAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCariSec frm = new frmCariSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Isbasatis.Entities.Tables.Cari entity = frm.secilen.FirstOrDefault();

                _cariId = entity.Id;
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
                bankaEntity.BankaId =Convert.ToInt32(_bankaId);
                btnBankaAdi.Text = entity.HesapIsmi;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 0)
            {
    

            }
          
        }
    }
}