using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;

using System.Runtime.Remoting.Contexts;

namespace IsbaSatis.Admin
{
    public partial class frmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        private Isbasatis.Entities.Tables.Kullanici _entity;
        IsbaSatisContext context = new IsbaSatisContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        public bool saved = false;
        private string parola, cevap;
        
        public frmKullaniciIslem(Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            if (entity != null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Cevap = null;
                entity.Parola = null;
            }
            _entity = entity;
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatırlatma.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            Ayar();
        }
        private void Ayar()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {
                        context.KullaniciRolleri.Add(new KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked
                        });
                    }
                    else
                    {
                        context.KullaniciRolleri.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki = treeList1.Nodes[i].Nodes[j].Checked;

                    }
                }
            }
            context.SaveChanges();
        }

        private void frmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrar.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;

            }
            if (txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Parola Ve Parola Tekrar Alanlarına Aynı Parolayı Girin");
            }
            else
            {

                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }
                if (kullaniciDAL.AddOrUpdate(context, _entity))
                {
                    kaydet();
                    saved = true;
                    this.Close();
                }


            }

        }
    }


}

