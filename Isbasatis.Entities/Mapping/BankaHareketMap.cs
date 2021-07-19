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
    public class BankaHareketMap : EntityTypeConfiguration<BankaHareket>
    {
        public BankaHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.Tutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("BankaHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.BankaId).HasColumnName("BankaId");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Tutar).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c => c.Banka).WithMany(c => c.BankaHareket).HasForeignKey(c => c.BankaId);
            this.HasOptional(c => c.Cari).WithMany(c => c.BankaHareket).HasForeignKey(c => c.CariId);
        }
    }
}
