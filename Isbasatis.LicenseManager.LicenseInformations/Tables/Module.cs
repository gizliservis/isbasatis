using Isbasatis.LicenseManager.LicenseInformations.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Tables
{
   public class Module
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("License")]
        public Guid LicenseId { get; set; }
        public ModuleTypeEnum ModuleTypeEnum { get; set; }

    }
}
