using Isbasatis.LicenseManager.LicenseInformations.Enums;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Isbasatis.LicenseManager.LicenseInformations.Tools;
using Isbasatis.LisansManager.SystemInformations.Manager;
using Isbasatis.LisansManager.SystemInformations.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isbasatis.LicenseManager.Client
{
   public class LicenseConfirmation
    {
        private readonly License license;
        List<SystemInfo> systemInfo = new List<SystemInfo>();
        bool confirmLicense = false;
        public LicenseConfirmation()
        {
            if (File.Exists(Application.StartupPath + "\\license.lic"))
            {

                string json = EncrpytionTool.Decrypt(File.ReadAllText(Application.StartupPath + "\\license.lic"));
                license = JsonConvert.DeserializeObject<LicenseManager.LicenseInformations.Tables.License>(json);
                LoadSystemInfo();
                int confirmedInfo = 0;
                for (int i = 0; i < 6; i++)
                {
                    var infoType = license.SystemInfos[i].InfoType;
                    
                    if (license.SystemInfos[i].Info==systemInfo.Where(c=>c.InfoType==infoType).FirstOrDefault().Info)
                    {
                        confirmedInfo += 1;
                    }
                }
                if (confirmedInfo>3)
                {
                    confirmLicense = true;
                }
            }
        
        }
        private void LoadSystemInfo()
        {
            
            SystemInformations info = new SystemInformations();
            DiskDrive drive = info.GetDiskLis().FirstOrDefault(c => c.PartitionName == Application.StartupPath.Substring(0, 2));
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.BaseBoard,
                Info = JsonConvert.SerializeObject(info.GetBaseBoardInfo())
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Bios,
                Info = JsonConvert.SerializeObject(info.GetBiosInfo())
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Cpu,
                Info = JsonConvert.SerializeObject(info.GetCpuInfo())
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Network,
                Info = JsonConvert.SerializeObject(info.GetNetworkList().FirstOrDefault())
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.DiskDrive,
                Info = JsonConvert.SerializeObject(drive)
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.OperatingSystem,
                Info = JsonConvert.SerializeObject(info.GetOSInfo())
            });
           
        }
        public bool ModuleConfirm(ModuleTypeEnum module)
        {
            if (!confirmLicense || license==null)
            {
                return false;
            }
            return license.Modules.Any(c => c.ModuleTypeEnum == module);
        }
    }
}
