using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.Admin
{
    public partial class frmDevir : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext kaynakContext;
        SqlConnectionStringBuilder connKyanak = new SqlConnectionStringBuilder();
        IsbaSatisContext hedefContext;
        SqlConnectionStringBuilder connHedef = new SqlConnectionStringBuilder();
        private List<string> dbList;
        public frmDevir()
        {
            InitializeComponent();

            connKyanak.DataSource = "DESKTOP-SLOIL0F";
            connKyanak.InitialCatalog = "master";
            connKyanak.IntegratedSecurity = true;
            kaynakContext = new IsbaSatisContext();
            dbList = kaynakContext.Database.SqlQuery<string>("Select name From master.dbo.sysdatabases Where name like 'isba%'").ToList();
            KaynakDbYukle();
            HedefDbYukle();
        }
        public void KaynakDbYukle()
        {
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("isbamarket","."),
                    GroupIndex=1,
                    Height = 100,
                    Width = 100
                };
                buton.Click += KaynakSec;
                flowKaynak.Controls.Add(buton);
            }
      
        }

        private void KaynakSec(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton)sender;
            connKyanak.DataSource = "DESKTOP-SLOIL0F";
            connKyanak.InitialCatalog = "isbamarket"+button.Text;
            connKyanak.IntegratedSecurity = true;
            kaynakContext = new IsbaSatisContext(connKyanak.ConnectionString);
        }

        public void HedefDbYukle()
        {
            SimpleButton YeniEkle = new SimpleButton
            {
                Name = "YeniDonemEkle",
                Text = "Yeni Dönem Ekle",
                Height = 100,
                Width = 100
            };
            YeniEkle.Click += YeniDonemEkle;
            flowHedef.Controls.Add(YeniEkle);
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("isbamarket", "."),
                    GroupIndex = 2,
                    Height = 100,
                    Width = 100
                };
                buton.Click += HedefSec;
                flowHedef.Controls.Add(buton);
            }

        }

        private void YeniDonemEkle(object sender, EventArgs e)
        {
            SimpleButton butonDonem = (SimpleButton)sender;
            frmDonemSec frm = new frmDonemSec();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(frm.donem))
            {
                if (!dbList.Contains("isbamarket"+frm.donem))
                {
                    dbList.Add("isbamarket" + frm.donem);
                    CheckButton buton = new CheckButton
                    {
                        Name = "isbamarket" + frm.donem,
                        Text = frm.donem,
                        GroupIndex = 2,
                        Height = 100,
                        Width = 100
                    };
                    buton.Click += HedefSec;
                    flowHedef.Controls.Add(buton);
                    connHedef.DataSource = "DESKTOP-SLOIL0F";
                    connHedef.InitialCatalog = "isbamarket" + buton.Text;
                    connHedef.IntegratedSecurity = true;
                    hedefContext = new IsbaSatisContext(connHedef.ConnectionString);
                    hedefContext.Database.CreateIfNotExists();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Dönem Zaten oluşturulmuş");
                }
              
            }
        }

        private void HedefSec(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton)sender;
            connHedef.DataSource = "DESKTOP-SLOIL0F";
            connHedef.InitialCatalog = "isbamarket" + button.Text;
            connHedef.IntegratedSecurity = true;
            hedefContext = new IsbaSatisContext(connHedef.ConnectionString);
        }
    }
}