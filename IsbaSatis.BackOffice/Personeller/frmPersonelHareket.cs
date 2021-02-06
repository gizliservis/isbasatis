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
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Personeller
{
    public partial class frmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        PersonelDAL personelDAL = new PersonelDAL();
        FisDAL fisDAL = new FisDAL();
        private int _personelId;
    
        public frmPersonelHareket(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            var personelBilgi = context.Personeller.SingleOrDefault(c => c.Id == personelId);
            lblBaslik.Text = personelBilgi.PersonelKodu + "-"+personelBilgi.PersonelAdi ;
        }

        private void frmPersonelHareket_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            gridcontPersonelHareket.DataSource = fisDAL.GetAll(context, c => c.PlasiyerId == _personelId);
            gridcontFisToplam.DataSource = personelDAL.PersonelFisToplam(context,_personelId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridPersonelHareket.OptionsView.ShowAutoFilterRow = true ? gridPersonelHareket.OptionsView.ShowAutoFilterRow == false : gridPersonelHareket.OptionsView.ShowAutoFilterRow == true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}