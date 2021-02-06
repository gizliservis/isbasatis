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
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        OdemeTuruDAL odemeTuruDAL = new OdemeTuruDAL();
        private OdemeTuru _entity;
        public frmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void frmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDAL.AddOrUpdate(context,_entity))
            {
                odemeTuruDAL.Save(context);
                this.Close();
                
            }
        }
    }
}