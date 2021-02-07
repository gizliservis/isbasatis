using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LisansManager.SystemInformations.Tables
{
   public class Bios
    {
        public string Version { get; set; }
        public string Caption { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
