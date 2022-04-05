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
        ExcellAktarimTool exc = new ExcellAktarimTool();
        StokDAL stokDal = new StokDAL();
        Isbasatis.Entities.Tables.Stok stkk = new Isbasatis.Entities.Tables.Stok();
        IsbaSatisContext context = new IsbaSatisContext();
        private ExportTool export;
        string filename = "ExceelStok.xml";

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

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (textEdit1.Text!="")
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

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                try
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {

                        Isbasatis.Entities.Tables.Stok stk = new Isbasatis.Entities.Tables.Stok();
                        stk.Durumu = Convert.ToBoolean(gridView1.GetRowCellValue(i, colDurumu) != null);
                        stk.StokKodu = (gridView1.GetRowCellValue(i, colStokKodu)).ToString();
                        stk.StokAdi = (gridView1.GetRowCellValue(i, colStokAdi)).ToString();
                        stk.Barkod = (gridView1.GetRowCellValue(i, colBarkod) ).ToString();
                        stk.BarkodTuru = (gridView1.GetRowCellValue(i, colBarkodTuru) != null).ToString();
                        stk.Birimi = (gridView1.GetRowCellValue(i, colBirimi)).ToString();
                        stk.StokGrubu = (gridView1.GetRowCellValue(i, colStokGrubu) != null).ToString();
                        stk.StokAltGrubu = (gridView1.GetRowCellValue(i, colStokAltGrubu) != null).ToString();
                        stk.Marka = (gridView1.GetRowCellValue(i, colMarka) != null).ToString();
                        stk.Modeli = (gridView1.GetRowCellValue(i, colModeli) != null).ToString();
                        stk.OzelKod1 = (gridView1.GetRowCellValue(i, colOzelKod1) != null).ToString();
                        stk.OzelKod2 = (gridView1.GetRowCellValue(i, colOzelKod2) != null).ToString();
                        stk.OzelKod3 = (gridView1.GetRowCellValue(i, colOzelKod3) != null).ToString();
                        stk.OzelKod4 = (gridView1.GetRowCellValue(i, colOzelKod4) != null).ToString();
                        stk.GarantiSuresi = (gridView1.GetRowCellValue(i, colGarantiSuresi) != null).ToString();
                        stk.UreticiKodu = (gridView1.GetRowCellValue(i, colUreticiKodu) != null).ToString();
                        stk.AlisKdv = Convert.ToInt32(gridView1.GetRowCellValue(i, colAlisKdv) != null);
                        stk.SatisKdv = Convert.ToInt32(gridView1.GetRowCellValue(i, colSatisKdv) != null);
                        stk.AlisFiyati1 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati1) != null);
                        stk.AlisFiyati2 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati2) != null);
                        stk.AlisFiyati3 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAlisFiyati3) != null);
                        stk.SatisFiyati1 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati1) != null);
                        stk.SatisFiyati2 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati2) != null);
                        stk.SatisFiyati3 = Convert.ToDecimal(gridView1.GetRowCellValue(i, colSatisFiyati3) != null);
                        stk.MinStokMiktari = Convert.ToDecimal(gridView1.GetRowCellValue(i, colMinStokMiktari) != null);
                        stk.MaxStokMiktari = Convert.ToDecimal(gridView1.GetRowCellValue(i, colMaxStokMiktari) != null);
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