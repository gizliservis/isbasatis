using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Mapping
{
   public class HizliSatisMap:EntityTypeConfiguration<HizliSatis>
    {
        public HizliSatisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Barkod).HasMaxLength(150);
            this.Property(p => p.UrunAdi).HasMaxLength(150);
            

            ToTable("HizliSatislar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
