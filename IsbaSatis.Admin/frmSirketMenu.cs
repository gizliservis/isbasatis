using DevExpress.Utils;
using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.Admin
{
    public partial class frmSirketMenu : DevExpress.XtraEditors.XtraForm
    {
        public string secilenDonem;
        public frmSirketMenu()
        {
            InitializeComponent();
            if (!ConnectionTool.CheckConnection(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi)))
            {
                frmBaglantiAyarlari frm = new frmBaglantiAyarlari();
                frm.ShowDialog();
            }
            DonemListele();
        }
        private void DonemListele()
        {

            List<string> dbList;
            IsbaSatisContext context = new IsbaSatisContext();

            dbList = context.Database.SqlQuery<string>("Select name From master.dbo.sysdatabases Where name like 'İsba%' and name like 'isba%'").ToList();
            SimpleButton btn = new SimpleButton
            {
                Name = "btnYeniSirketEkle",
                Text = "Yeni Şirket Oluştur",
                Height = 250,
                Width=200,
               
            };
            btn.Appearance.Font=new Font("Tahoma",14,FontStyle.Bold);
            btn.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
            btn.Click += btnYeniSirketEkle;
            flowLayoutPanel1.Controls.Add(btn);
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("İsba", ""),
                    GroupIndex = 1,
                    ImageList = ımageList1,
                    ImageIndex = 1,
                    Height = 250,
                    Width = 250,

                };
                buton.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
                buton.Click += SecilenButon;
                flowLayoutPanel1.Controls.Add(buton);
            }
        }

        private void btnYeniSirketEkle(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            frmBaglantiAyarlari form = new frmBaglantiAyarlari();
            form.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            DonemListele();
        }

        private void SecilenButon(object sender, EventArgs e)
        {
            CheckButton buton = (CheckButton)sender;
            if (buton.Text.Contains("isba"))
            {
                secilenDonem = buton.Text;

            }
            else
            {
                secilenDonem = "İsba" + buton.Text;
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(secilenDonem))
            {
                MessageBox.Show("Lütfen Bir şirket Seçiniz");
            }
            else
            {
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}