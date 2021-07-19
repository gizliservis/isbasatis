using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Mapping
{
    class BankaMap: EntityTypeConfiguration<Banka>
    {
        public BankaMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.HesapKodu).HasMaxLength(12);
            this.Property(p => p.HesapIsmi).HasMaxLength(50);
            this.Property(p => p.Bankasi).HasMaxLength(30);
            this.Property(p => p.Sube).HasMaxLength(50);
            this.Property(p => p.IbanNo).HasMaxLength(24);
            this.Property(p => p.HesapNo).HasMaxLength(14);
            this.Property(p => p.YetkiliAdi).HasMaxLength(50);
            this.Property(p => p.YetkiliTelefonu).HasMaxLength(11);

            this.ToTable("Bankalar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.HesapKodu).HasColumnName("HesapKodu");
            this.Property(p => p.HesapIsmi).HasColumnName("HesapIsmi");
            this.Property(p => p.Bankasi).HasColumnName("Bankasi");
            this.Property(p => p.Sube).HasColumnName("Sube");
            this.Property(p => p.IbanNo).HasColumnName("IbanNo");
            this.Property(p => p.HesapNo).HasColumnName("HesapNo");
            this.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(p => p.YetkiliTelefonu).HasColumnName("YetkiliTelefonu");


        }
    }
}
