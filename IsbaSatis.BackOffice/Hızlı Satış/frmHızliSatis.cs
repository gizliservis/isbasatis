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
using System.Data.Entity;
using DevExpress.XtraCharts.Design;
using IsbaSatis.BackOffice.Stoklar;

namespace IsbaSatis.BackOffice.Hızlı_Satış
{
    public partial class frmHızliSatis : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        HizliSatisGrupDAL hizliSatisGrupDAL = new HizliSatisGrupDAL();
        HizliSatisDAL hizliSatisDAL = new HizliSatisDAL();
        public frmHızliSatis()
        {
            InitializeComponent();
            context.hizliSatisGruplari.Load();
            context.HizliSatislar.Load();
            gridcontGrupEkle.DataSource = context.hizliSatisGruplari.Local.ToBindingList();
            gridContUrunEkle.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void frmHızliSatis_Load(object sender, EventArgs e)
        {

        }
        private void KayitAc()
        {
            grpGrupBilgi.Enabled = true;
            BtnYeni.Enabled = false;
            btnSill.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            gridContUrunEkle.Enabled = false;
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void KayitKapat()
        {
            grpGrupBilgi.Enabled = false;
            BtnYeni.Enabled = true;
            btnSill.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            gridContUrunEkle.Enabled = true;
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void gridGrupEkle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridUrunEkle.ActiveFilterString = $"GrupId='{gridGrupEkle.GetFocusedRowCellValue(colId)}'";
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hizliSatisGrupDAL.AddOrUpdate(context, new Isbasatis.Entities.Tables.HizliSatisGrup
            {
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
            });
            hizliSatisGrupDAL.Save(context);
            txtGrupAdi.Text = null;
            txtAciklama.Text = null;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtGrupAdi.Text = null;
            txtAciklama.Text = null;
        }

        private void btnSill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Grup İle Birlikte Bu Gruba Eklenmiş Tüm Ürünler Silinecektir Onaylıyormusunuz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int grupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId);
                hizliSatisDAL.Delete(context, c => c.GrupId == grupId);
                gridGrupEkle.DeleteSelectedRows();
                hizliSatisDAL.Save(context);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec frm = new frmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemStok in frm.secilen)
                {
                    if (context.HizliSatislar.Count(c => c.Barkod == itemStok.Barkod) == 0)
                    {
                        hizliSatisDAL.AddOrUpdate(context, new Isbasatis.Entities.Tables.HizliSatis
                        {
                            Barkod = itemStok.Barkod,
                            UrunAdi = itemStok.StokAdi,
                            GrupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId1)
                        });
                        hizliSatisDAL.Save(context);
                    }

                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan ürünleri listeden çıkarmak istediğinize EMİNMİSİNİZ", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridUrunEkle.DeleteSelectedRows();
                hizliSatisDAL.Save(context);
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}