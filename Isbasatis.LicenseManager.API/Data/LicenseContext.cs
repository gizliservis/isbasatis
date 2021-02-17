

using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.API.Data
{
    public class LicenseContext:DbContext
    {
        public LicenseContext(DbContextOptions options):base(options)
        {


        }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<SystemInfo> systemInfos { get; set; }


    }
}
