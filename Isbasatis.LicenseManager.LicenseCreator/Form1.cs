using Isbasatis.LicenseManager.LicenseInformations.Enums;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Isbasatis.LisansManager.SystemInformations.Manager;
using Isbasatis.LisansManager.SystemInformations.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Isbasatis.LicenseManager.LicenseCreator
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLisanOlustur_Click(object sender, EventArgs e)
        {
            LicenseInformations.Tables.License lisans = new LicenseInformations.Tables.License();
            SystemInformations info = new SystemInformations();

            DiskDrive drive = info.GetDiskLis().FirstOrDefault(c => c.PartitionName == Application.StartupPath.Substring(0, 2));


            lisans.Id = Guid.NewGuid();
            lisans.UserName = txtUserName.Text;
            lisans.Company = txtCompany.Text;
            for (int i = 0; i < checkedListBoxControl1.Items.Count; i++)
            {
                if (checkedListBoxControl1.Items[i].CheckState == CheckState.Checked)
                {
                    lisans.Modules.Add(new Module
                    {
                        ModuleTypeEnum = (ModuleTypeEnum)i

                    });
                }

            }
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.BaseBoard,
                Info = JsonConvert.SerializeObject(info.GetBaseBoardInfo())
            });
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Bios,
                Info = JsonConvert.SerializeObject(info.GetBiosInfo())
            });
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Cpu,
                Info = JsonConvert.SerializeObject(info.GetCpuInfo())
            });
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Network,
                Info = JsonConvert.SerializeObject(info.GetNetworkList().FirstOrDefault())
            });
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.DiskDrive,
                Info = JsonConvert.SerializeObject(drive)
            });
            lisans.SystemInfos.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.OperatingSystem,
                Info = JsonConvert.SerializeObject(info.GetOSInfo())
            });
            var json = JsonConvert.SerializeObject(lisans);
            XtraSaveFileDialog dialog = new XtraSaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, LicenseInformations.Tools.EncrpytionTool.Encrypt(json));
            }
        }
    }
}
