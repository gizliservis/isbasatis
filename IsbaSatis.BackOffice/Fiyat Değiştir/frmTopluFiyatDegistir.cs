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
using Isbasatis.Entities.Tables.Other_Tables;

namespace IsbaSatis.BackOffice.Fiyat_Değiştir
{
    public partial class frmTopluFiyatDegistir : DevExpress.XtraEditors.XtraForm
    {
        public List<FiyatDegistir> list;
        public bool secildi = false;
        public frmTopluFiyatDegistir()
        {
            InitializeComponent();
            list = new List<FiyatDegistir>
            {
                new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-1",
                    KolonAdi="AlisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },
                      new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-2",
                    KolonAdi="AlisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },
                            new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-3",
                    KolonAdi="AlisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },
                new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-1",
                    KolonAdi="SatisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },
                  new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-2",
                    KolonAdi="SatisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },
                    new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-3",
                    KolonAdi="SatisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0

                },   
            };
            gridControl1.DataSource = list;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}