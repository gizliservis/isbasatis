using Isbasatis.LicenseManager.LicenseInformations.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Manager
{
    public class SystemInformations
    {
        public List<Network> GetNetworkList()
        {
            List<Network> list = new List<Network>();
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces().Where(c => c.OperationalStatus == OperationalStatus.Up && !String.IsNullOrEmpty(c.GetPhysicalAddress().ToString())))
            {
                list.Add(new Network
                {
                    Caption = network.Name,
                    Description = network.Description,
                    MacAddress = network.GetPhysicalAddress().ToString()
                });
            }
            return list;
        }
        public Bios GetBiosInfo()
        {
            ManagementObjectSearcher manegament = new ManagementObjectSearcher("Select Version,Caption,Manufacturer,SerialNumber,ReleaseDate From Win32_BIOS");
            ManagementObjectCollection collection = manegament.Get();
            Bios bios = new Bios();
            foreach (var prop in collection)
            {
                bios.Version = prop["Version"].ToString();
                bios.Caption = prop["Caption"].ToString();
                bios.Manufacturer = prop["Manufacturer"].ToString();
                bios.ReleaseDate = ManagementDateTimeConverter.ToDateTime(prop["ReleaseDate"].ToString());
                bios.SerialNumber = prop["SerialNumber"].ToString();

            }
            return bios;
        }
        public BaseBoard GetBaseBoardInfo()
        {
            ManagementObjectSearcher management = new ManagementObjectSearcher("Select Name,Product,Manufacturer,SerialNumber From Win32_BaseBoard");
            ManagementObjectCollection collection = management.Get();
            BaseBoard baseBoard = new BaseBoard();
            foreach (ManagementObject prop in collection)
            {
                baseBoard.Name = prop["Name"].ToString();

                baseBoard.Manufacturer = prop["Manufacturer"].ToString();
                baseBoard.Product = prop["Product"].ToString();
                baseBoard.SerialNumber = prop["SerialNumber"].ToString();
            }
            return baseBoard;
        }
        public Cpu GetCpuInfo()
        {
            ManagementObjectSearcher management = new ManagementObjectSearcher("Select Name,Caption,DeviceID,ProcessorId,NumberOfCores From Win32_Processor");
            ManagementObjectCollection collection = management.Get();
            Cpu cpu = new Cpu();
            foreach (ManagementObject prop in collection)
            {
                cpu.Name = prop["Name"].ToString();
                cpu.Caption = prop["Caption"].ToString();
                cpu.DeviceID = prop["DeviceID"].ToString();
                cpu.ProcessorId = prop["ProcessorId"].ToString();
                cpu.NumberOfCores = prop["NumberOfCores"].ToString();
            }
            return cpu;
        }
        public OperatiingSystem GetOSInfo()
        {
            ManagementObjectSearcher management = new ManagementObjectSearcher("Select Name,Caption,SerialNumber,RegisteredUser From Win32_OperatingSystem");
            ManagementObjectCollection collection = management.Get();
            OperatiingSystem os = new OperatiingSystem();
            foreach (var prop in collection)
            {
                os.Name = prop["Name"].ToString();
                os.Caption = prop["Caption"].ToString();
                os.SerialNumber = prop["SerialNumber"].ToString();
                os.RegisteredUser = prop["RegisteredUser"].ToString();
            }
            return os;

        }
        public List<DiskDrive> GetDiskLis()
        {
            List<DiskDrive> list = new List<DiskDrive>();
            ManagementObjectSearcher diskManagement = new ManagementObjectSearcher("Select Name,Caption,DeviceID,SerialNumber,Model From Win32_DiskDrive");
            foreach (ManagementObject drive in diskManagement.Get())
            {
                ManagementObjectSearcher partitionManagement = new ManagementObjectSearcher(string.Format("associators of {{{0}}} where AssocClass=Win32_DiskDriveToDiskPartition",drive.Path.RelativePath));
                foreach (ManagementObject partition in partitionManagement.Get())
                {
                    
                    ManagementObjectSearcher logicalManagement = new ManagementObjectSearcher(string.Format("associators of {{{0}}} where AssocClass=Win32_LogicalDiskToPartition",partition.Path.RelativePath));

                    foreach (ManagementObject locigalDisk in logicalManagement.Get())
                    {
                        list.Add(new DiskDrive
                        {
                            Name=drive["Name"].ToString(),
                            SerialNumber=drive["SerialNumber"].ToString(),
                            Caption=drive["Caption"].ToString(),
                            DeviceID=drive["DeviceID"].ToString(),
                            Model=drive["Model"].ToString(),
                            FileSystem=locigalDisk["FileSystem"].ToString(),
                            MediaType=locigalDisk["MediaType"].ToString(),
                            PartitionName=locigalDisk["Name"].ToString(),
                            VolumeSerialNumber=locigalDisk["VolumeSerialNumber"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
