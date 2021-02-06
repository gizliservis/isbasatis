using Isbasatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using Isbasatis.Entities.Tools;

namespace IsbaSatisBackup
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        public frmBackup()
        {
            InitializeComponent();
            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string SqlCumle = $"USE IsbaSatis;BACKUP DATABASE IsbaSatis TO DISK='{txtYedekKonum.Text + "\\IsbaSatis.nsy"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, SqlCumle);
            MessageBox.Show("Yedekleme İşlemi Başarıyla Gerçekleştirildi.");
        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog()==DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu,txtYedekKonum.Text);
                SettingsTool.save();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "İsba Satış Yedekleme Dosyası *.nsy|*.nsy";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                string sqlCumle = $"USE master;ALTER DATABASE IsbaSatis SET SINGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE IsbaSatis SET READ_ONLY;RESTORE DATABASE IsbaSatis FROM DISK='{dialog.FileName}'; ALTER DATABASE IsbaSatis SET MULTI_USER";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
            }
        }
    }
}
