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
using IsbaSatis.BackOffice.Stoklar;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using System.Data.Entity;
using Isbasatis.Entities.Tools;
using System.IO;

namespace IsbaSatis.BackOffice.Fiyat_Değiştir
{
    public partial class frmTopluFiyat : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        StokDAL stokDAL = new StokDAL();
        private ExportTool export;
        string filename = "TopluFiyatD.xml";
        public frmTopluFiyat()
        {
            InitializeComponent();
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }

            listele();
        }
        private void listele()
        {
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec frm = new frmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemstok in frm.secilen)
                {
                    stokDAL.AddOrUpdate(context, itemstok);
                }
            }
        }

        private void btnDegisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fiyat Değişikliklerini Kaydetmek İstiyormusunuz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                stokDAL.Save(context);
                this.Close();
            }
           
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
       
            var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = stokDAL.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow == true)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
            
                
               
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount==0)
            {
                MessageBox.Show("Secilen Bir Stok Bulunamadı");
                return;
            }
            frmTopluFiyatDegistir frm = new frmTopluFiyatDegistir();
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemDegistir in frm.list)
                {
                    if (itemDegistir.Degistir)
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            decimal kolondeger;
                            decimal degisen = 0;
                            kolondeger = Convert.ToDecimal(gridView1.GetRowCellValue(i, itemDegistir.KolonAdi));
                            if (itemDegistir.DegisimTuru=="Yüzde")
                            {
                                degisen =itemDegistir.DegisimYonu=="Arttır" ? kolondeger + kolondeger / 100 * itemDegistir.Degeri: kolondeger - kolondeger / 100 * itemDegistir.Degeri;
                            }
                            else
                            {
                                degisen = itemDegistir.DegisimYonu == "Arttır" ? kolondeger + itemDegistir.Degeri : kolondeger - itemDegistir.Degeri;
                            }
                            gridView1.SetRowCellValue(i, itemDegistir.KolonAdi, degisen);
                        }

                    }
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}