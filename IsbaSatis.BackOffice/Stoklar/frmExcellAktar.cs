using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Stoklar
{
    public partial class frmExcellAktar : DevExpress.XtraEditors.XtraForm
    {
        readonly ExcellAktarimTool exc = new ExcellAktarimTool();
        readonly StokDAL stokDal = new StokDAL();
        readonly IsbaSatisContext context = new IsbaSatisContext();
        private readonly ExportTool export;
        readonly string filename = "ExceelStok.xml";

        public frmExcellAktar()
        {
            InitializeComponent();
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
        }

        private void ButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (textEdit1.Text != "")
            {
                try
                {
                    gridControl1.DataSource = exc.ExcellAktar(textEdit1.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void ButtonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {

                        Isbasatis.Entities.Tables.Stok stk = new Isbasatis.Entities.Tables.Stok
                        {
                            Durumu = Convert.ToBoolean(gridView1.GetRowCellValue(i, colDurumu) != null),
                            StokKodu = (gridView1.GetRowCellValue(i, colStokKodu)).ToString(),
                            StokAdi = (gridView1.GetRowCellValue(i, colStokAdi)).ToString(),
                            Barkod = (gridView1.GetRowCellValue(i, colBarkod)).ToString(),
                            BarkodTuru = (gridView1.GetRowCellValue(i, colBarkodTuru) != null).ToString(),
                            Birimi = (gridView1.GetRowCellValue(i, colBirimi)).ToString(),
                            StokGrubu = (gridView1.GetRowCellValue(i, colStokGrubu) != null).ToString(),
                            StokAltGrubu = (gridView1.GetRowCellValue(i, colStokAltGrubu) != null).ToString(),
                            Marka = (gridView1.GetRowCellValue(i, colMarka) != null).ToString(),
                            Modeli = (gridView1.GetRowCellValue(i, colModeli) != null).ToString(),
                            OzelKod1 = (gridView1.GetRowCellValue(i, colOzelKod1) != null).ToString(),
                            OzelKod2 = (gridView1.GetRowCellValue(i, colOzelKod2) != null).ToString(),
                            OzelKod3 = (gridView1.GetRowCellValue(i, colOzelKod3) != null).ToString(),
                            OzelKod4 = (gridView1.GetRowCellValue(i, colOzelKod4) != null).ToString(),
                            GarantiSuresi = (gridView1.GetRowCellValue(i, colGarantiSuresi) != null).ToString(),
                            UreticiKodu = (gridView1.GetRowCellValue(i, colUreticiKodu) != null).ToString(),
                            AlisKdv = Convert.ToInt32(gridView1.GetRowCellValue(i, colAlisKdv) != null),
                            SatisKdv = Convert.ToInt32(gridView1.GetRowCellValue(i, colSatisKdv) != null),
                            AlisFiyati1 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati1) != null),
                            AlisFiyati2 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati2) != null),
                            AlisFiyati3 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati3) != null),
                            SatisFiyati1 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati1) != null),
                            SatisFiyati2 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati2) != null),
                            SatisFiyati3 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati3) != null),
                            MinStokMiktari = Convert.ToDecimal(gridView1.GetRowCellValue(i, colMinStokMiktari) != null),
                            MaxStokMiktari = Convert.ToDecimal(gridView1.GetRowCellValue(i, colMaxStokMiktari) != null)
                        };
                        stokDal.AddOrUpdate(context, stk);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Lütrfen Excell Dosyası Seçiniz");
            }


        }
    }
}