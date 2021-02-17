using Isbasatis.LicenseManager.LicenseInformations.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Tables
{
   public class License
    {
        public License()
        {
            SystemInfos = new List<SystemInfo>();
            Modules = new List<Module>();
        }
        [Key]
        public Guid Id { get; set; }
        public LicenseType LicenseType { get; set; }
        public bool OnlineLisans { get; set; }
        public string UserName { get; set; }
        public string Company { get; set; }
        public int LicenseCount { get; set; }
        public List<SystemInfo> SystemInfos { get; set; }
        public List<Module> Modules { get; set; }

    }
}
