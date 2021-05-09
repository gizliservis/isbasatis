using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Fişler
{

    public partial class frmFis : DevExpress.XtraEditors.XtraForm
    {

        IsbaSatisContext context = new IsbaSatisContext();
        FisDAL fisDAL = new FisDAL();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        Fis Fis = new Fis();
       
        public frmFis()
        {
            InitializeComponent();
            RolTool.RolleriYukle(this);
            listele();
        }

     
        private void listele()
        {
            gridControl1.DataSource = fisDAL.GetAll(context);
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = fisDAL.GetAll(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Fis secilen = (Fis)gridView1.GetFocusedRow();
            if (!String.IsNullOrEmpty(secilen.FisBaglantiKodu))
            {
                if (MessageBox.Show($"Bu fis ile bağlantılı olan{secilen.FisBaglantiKodu} kodlu fiş birlikte silinecektir , Eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    listele();
                }
            }
            else
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinie Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //  string secilen = gridFis.GetFocusedRowCellValue(colFisKodu).ToString();
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    listele();
                }
            }


        }


        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFislerVeFaturalar frm = new frmFislerVeFaturalar(null, e.Item.Caption);
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Fis secilen = (Fis)gridView1.GetFocusedRow();
            if (secilen.FisTuru == "Fiş Ödemesi")
            {
                frmFislerVeFaturalar form = new frmFislerVeFaturalar(secilen.FisBaglantiKodu, null);
                form.ShowDialog();
            }
            else
            {
                frmFislerVeFaturalar form = new frmFislerVeFaturalar(secilen.FisKodu, null);
                form.ShowDialog();
            }
           // string secilen = gridFis.GetFocusedRowCellValue(colFisKodu).ToString();

        }
    }
}