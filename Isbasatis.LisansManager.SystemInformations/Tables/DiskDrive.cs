using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LisansManager.SystemInformations.Tables
{
   public class DiskDrive
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string DeviceID { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string PartitionName { get; set; }
        public string FileSystem { get; set; }
        public string MediaType { get; set; }
        public string VolumeSerialNumber { get; set; }
    }
}
