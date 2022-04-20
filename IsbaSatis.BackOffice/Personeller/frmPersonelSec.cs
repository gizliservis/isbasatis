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
using DevExpress.Utils.Extensions;
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.Personeller
{
    public partial class frmPersonelSec : DevExpress.XtraEditors.XtraForm
    {
        PersonelDAL personelDAL = new PersonelDAL();
        IsbaSatisContext context = new IsbaSatisContext();
        public bool secildi;
        public List<PersonelHareket> secilen = new List<PersonelHareket>();
        private DateTime _donem;
        public frmPersonelSec(DateTime donemi,bool coklusecim = false)
        {
            InitializeComponent();
            if (coklusecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            _donem = donemi;
            gridControl1.DataSource = personelDAL.TariheGorePersonelListele(context,donemi.Month,donemi.Year);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {

                foreach (var row in gridView1.GetSelectedRows())
                {
                    string personelKodu = gridView1.GetRowCellValue(row, colPersonelKodu).ToString();
                    secilen.Add(new PersonelHareket
                    {
                        PersonelKodu = gridView1.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = gridView1.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = gridView1.GetRowCellValue(row, colTcKimlikNo).ToString(),
                        Unvani = gridView1.GetRowCellValue(row, colUnvani).ToString(),
                        Donemi = _donem,
                        AylikMaasi=Convert.ToDecimal(gridView1.GetRowCellValue(row, colAylikMaasi)),
                        PrimOrani= Convert.ToDecimal(gridView1.GetRowCellValue(row, colPrimOrani)),
                        ToplamSatis = Convert.ToDecimal(gridView1.GetRowCellValue(row, colToplamSatis)),
                    }) ;

                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Cari Bulunamadı");
            }

        }
    }
}