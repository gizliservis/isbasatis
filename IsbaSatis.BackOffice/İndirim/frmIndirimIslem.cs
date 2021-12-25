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
using IsbaSatis.BackOffice.Stoklar;
using Isbasatis.Entities.Tables;

namespace IsbaSatis.BackOffice.İndirim
{
    public partial class frmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        IndirimDAL indirimDAL = new IndirimDAL();
        public frmIndirimIslem()
        {
            InitializeComponent();
            gridContIndirimler.DataSource = context.Indirimler.Local.ToBindingList();

        }
        private Indirim StokEkle(Isbasatis.Entities.Tables.Stok entity)
        {
            Indirim _entity = new Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            return _entity;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec frm = new frmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemStok in frm.secilen)
                {
                    Indirim _entity = new Indirim();
                    _entity = StokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.StokKodu == itemStok.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Seçili Olan Stoğa Daha Önceden Eklenmiş İndirim Bulunmaktadır.Var Olan İndirimi Güncellemek İstermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenId.Id;
                            indirimDAL.AddOrUpdate(context, _entity);
                        }
                    }
                    else
                    {
                        indirimDAL.AddOrUpdate(context, _entity);
                    }
                }

            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    itemIndirim.IndirimTuru = "Süresiz";

                }
                else 
                {
                    itemIndirim.BaslangicTarihi = dateBaslangic.DateTime;
                    itemIndirim.BitisTarihi = dateBitis.DateTime;
                    itemIndirim.IndirimTuru = "Tarih Arasında";
                }



            }
            indirimDAL.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Listeden Çıkarmak İstediğinize Eminmisiniz","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
  var secilenStokKodu = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilen = indirimDAL.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            context.Entry(secilen).State = EntityState.Detached;
            }
          
        }
    }
}