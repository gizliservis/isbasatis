using Isbasatis.LicenseManager.LicenseInformations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Tables
{
   public class SystemInfo
    {
        public SystemInfoEnum InfoType { get; set; }
        public string Info { get; set; }

    }
}
