using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsbaSatis.Update
{
    public partial class frmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public frmGuncelleme()
        {
            InitializeComponent();
            if (IsRunning("IsbaSatis.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme İşleminden Önce Açık Olan uygulamaların Kapatılması Gerekiyor. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("IsbaSatis.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
