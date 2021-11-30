using Isbasatis.LicenseManager.LicenseInformations.Enums;
using Isbasatis.LicenseManager.LicenseInformations.Manager;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Isbasatis.LicenseManager.LicenseInformations.Tools;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isbasatis.LicenseManger.LicenseInformations.Manager
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
                int onlineConfirmedInfo = 0;
                bool onlineLicenseError = false;
                if (license.OnlineLisans != OnlineLicenseControl.None)
                {
                    try
                    {

                        License onlineLicense = GetOnlineLicense(license.Id);

                        for (int i = 0; i < 6; i++)
                        {
                            var infoType = license.SystemInfos.ToList()[i].InfoType;

                            if (onlineLicense.SystemInfos.ToList()[i].Info == systemInfo.Where(c => c.InfoType == infoType).FirstOrDefault().Info)
                            {
                                onlineConfirmedInfo += 1;
                            }

                        }
                    }
                    catch (Exception)
                    {

                        onlineLicenseError = true;
                    }
                }


                int confirmedInfo = 0;
                for (int i = 0; i < 6; i++)
                {
                    var infoType = license.SystemInfos.ToList()[i].InfoType;

                    if (license.SystemInfos.ToList()[i].Info == systemInfo.Where(c => c.InfoType == infoType).FirstOrDefault().Info)
                    {
                        confirmedInfo += 1;
                    }
                }
                if (confirmedInfo > 3)
                {
                    if (license.OnlineLisans == OnlineLicenseControl.Required && onlineLicenseError)
                    {
                      
                            confirmLicense = false;
                        return;
                      


                    }
                    if (license.OnlineLisans!=OnlineLicenseControl.None && !onlineLicenseError)
                    {
                        if (onlineConfirmedInfo > 3  )
                        {
                            confirmLicense = true;
                        }
                        else
                        {
                            confirmLicense = false;
                            return;
                        }
                    }
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
                Info =Md5Hash.HashMd5(JsonConvert.SerializeObject(info.GetBaseBoardInfo()))
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Bios,
                Info =Md5Hash.HashMd5( JsonConvert.SerializeObject(info.GetBiosInfo()))
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Cpu,
                Info =Md5Hash.HashMd5(JsonConvert.SerializeObject(info.GetCpuInfo()))
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.Network,
                Info =Md5Hash.HashMd5(JsonConvert.SerializeObject(info.GetNetworkList().FirstOrDefault()))
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.DiskDrive,
                Info = Md5Hash.HashMd5(JsonConvert.SerializeObject(drive))
            });
            systemInfo.Add(new SystemInfo
            {
                InfoType = SystemInfoEnum.OperatingSystem,
                Info = Md5Hash.HashMd5(JsonConvert.SerializeObject(info.GetOSInfo()))
            });

        }
        public bool ModuleConfirm(ModuleTypeEnum module)
        {
            if (!confirmLicense || license == null)
            {
                return false;
            }
            return license.Modules.Any(c => c.ModuleTypeEnum == module);
        }
        public LicenseInfo GetLicenseInfo()
        {
            return new LicenseInfo
            {
                UserName = license.UserName,
                Company = license.Company,
                LicenseCount = license.LicenseCount
            };
        }
        public License GetOnlineLicense(Guid id)
        {
            RestClient client = new RestClient("http://localhost:53633/");
            RestRequest request = new RestRequest("api/license/getlicense");
            request.AddParameter("id", id);
            var response = client.Get(request);
            var result = JsonConvert.DeserializeObject<ApiResponseResult>(EncrpytionTool.Decrypt(response.Content.Trim('\"')));
            if (result.returnType == ReturnType.Error)
            {
                MessageBox.Show(result.Value.ToString());

            }
            else if (result.returnType == ReturnType.Confirm)
            {
                License returnLicense = JsonConvert.DeserializeObject<License>(result.Value.ToString());
                return returnLicense;

            }
            return null;

        }

    }
}
