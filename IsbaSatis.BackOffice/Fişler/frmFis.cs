﻿using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Tools;
using IsbaSatis.BackOffice.Bankalar;
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
        BankaHareketDAL bankaHareketDAL = new BankaHareketDAL();
        Fis fis = new Fis();

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             listele();
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
                if (MessageBox.Show($"fis ile bağlantılı olan{secilen.FisBaglantiKodu} kodlu fiş birlikte silinecektir , Eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                    stokHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    kasaHareketDAL.Save(context);
                    stokHareketDAL.Save(context);
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
                    bankaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    kasaHareketDAL.Save(context);
                    stokHareketDAL.Save(context);
                    bankaHareketDAL.Save(context);
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
            if (secilen.FisTuru == "Gelen Havale"|| secilen.FisTuru == "Giden Havale" || secilen.FisTuru == "Gelen EFT" ||secilen.FisTuru== "Giden EFT" || secilen.FisTuru == "Bankaya Yatırılan Nakit" || secilen.FisTuru== "Bankadan Çekilen Nakit")
            {
                //BankaHareket bnk = new BankaHareket();
            
                frmBankaIslemleri frm = new frmBankaIslemleri(secilen.FisKodu);
                frm.ShowDialog();
                listele();
            }
           else if (secilen.FisTuru == "Fiş Ödemesi")
            {
                frmFislerVeFaturalar form = new frmFislerVeFaturalar(secilen.FisBaglantiKodu, null);
                form.ShowDialog();
                listele();
            }

            else
            {
                frmFislerVeFaturalar form = new frmFislerVeFaturalar(secilen.FisKodu, null);
                form.ShowDialog();
                listele();
            }
            // string secilen = gridFis.GetFocusedRowCellValue(colFisKodu).ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Fis secilen = (Fis)gridView1.GetFocusedRow();
            if (!secilen.FisTuru.Contains("Sipariş Fişi"))
            {
                MessageBox.Show("Faturalandırmak İstediğiniz Fiş Sipariş Fişi Değildir");
            }
            else
            {
                frmFislerVeFaturalar form = new frmFislerVeFaturalar(secilen.FisKodu, null, siparisFaturalandir: true);
                form.ShowDialog();
                listele();
            }
        }

        private void barBankaIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBankaIslemleri islem = new frmBankaIslemleri(null);
            islem.ShowDialog();
            listele();
        }
    }
}