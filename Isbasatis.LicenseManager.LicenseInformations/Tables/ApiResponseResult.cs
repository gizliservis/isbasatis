using Isbasatis.LicenseManager.LicenseInformations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Tables
{
   public class ApiResponseResult
    {
        public ReturnType returnType { get; set; }
        public object Value { get; set; }

    }
}
