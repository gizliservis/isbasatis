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
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Data_Access;

namespace IsbaSatis.BackOffice.Tanım
{
    public partial class frmTanim : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        TanimDal tanimDAL=new TanimDal();
        public Tanim _entity;
        private TanimTuru _tanimTuru;
        public bool secildi=false;
        public frmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;
        }
        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            Birimi,
            StokGrubu,
            StokAltGrubu,
            Marka,
            Modeli,
            OzelKod1,
            OzelKod2,
            OzelKod3,
            OzelKod4,
            PersonelUnvan
        }
        private void frmTanim_Load(object sender, EventArgs e)
        {
            listele();

        }
        void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;
            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }
        void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }
        void listele()
        {
            gridControl2.DataSource = tanimDAL.GetAll(context,c=>c.Turu==_tanimTuru.ToString());
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            _entity = new Tanim();
            KayitAc();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           
            int secilen = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               int secilen =Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
                tanimDAL.Delete(context, c => c.Id == secilen);
                tanimDAL.Save(context);
                listele();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimTuru.ToString();
            if (tanimDAL.AddOrUpdate(context,_entity))
            {
                tanimDAL.Save(context);
                KayitKapat();
                listele();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            secildi = true; 
            this.Close();
        }
    }
}