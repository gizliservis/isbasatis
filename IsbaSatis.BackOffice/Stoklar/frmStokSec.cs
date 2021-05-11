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

namespace IsbaSatis.BackOffice.Stoklar
{
    public partial class frmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDAL = new StokDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool secildi = false;
        public List<Isbasatis.Entities.Tables.Stok> secilen = new List<Isbasatis.Entities.Tables.Stok>();
        public bool kaydedildi = false;
        public frmStokSec(bool coklusecim=false)
           
        {
            InitializeComponent();
            if (coklusecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string StokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == StokKodu));
                }
                secildi = true;
                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Ürün Bulunamadı.");
            }
      
        }

        private void frmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = stokDAL.StokListele(context);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStoklar.OptionsView.ShowAutoFilterRow == true)
            {
                gridStoklar.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStoklar.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}