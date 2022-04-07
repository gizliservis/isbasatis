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
    public class SirketBilgiMap : EntityTypeConfiguration<SirketBilgi>
    {
        public SirketBilgiMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SirketKodu).HasMaxLength(12);
            this.Property(p => p.SirketKisaAdi).HasMaxLength(50);
            this.Property(p => p.SirketUnvani).HasMaxLength(150);
            this.Property(p => p.Ili).HasMaxLength(30);
            this.Property(p => p.Ilcesi).HasMaxLength(30);
            this.Property(p => p.Semt).HasMaxLength(30);
            this.Property(p => p.SirketTelNo).HasMaxLength(11);
            this.Property(p => p.Ulkesi).HasMaxLength(30);
            this.Property(p => p.VergiDairesi).HasMaxLength(30);
            this.Property(p => p.VergiNo).HasMaxLength(11);
            this.Property(p => p.Web).HasMaxLength(100);
            this.Property(p => p.YetkiliKisi).HasMaxLength(50);
            this.Property(p => p.Fax).HasMaxLength(30);
            this.Property(p => p.EMail).HasMaxLength(50);
            this.Property(p => p.Adres).HasMaxLength(250);
            this.Property(p => p.Aciklama).HasMaxLength(200);


            this.ToTable("SirketBilgileri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.SirketKodu).HasColumnName("SirketKodu");
            this.Property(p => p.SirketKisaAdi).HasColumnName("SirketKisaAdi");
            this.Property(p => p.SirketUnvani).HasColumnName("SirketUnvani");
            this.Property(p => p.Ili).HasColumnName("Ili");
            this.Property(p => p.Ilcesi).HasColumnName("Ilcesi");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.SirketTelNo).HasColumnName("SirketTelNo");
            this.Property(p => p.Ulkesi).HasColumnName("Ulkesi");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

        }
    }
}
