using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isbasatis.LicenseManager.LicenseInformations.Enums;

namespace Isbasatis.LicenseManager.LicenseInformations.Tables
{
   public class TcpMessage
    {
        public MessageType MessageType { get; set; }
        public string Message { get; set; }

    }
}
