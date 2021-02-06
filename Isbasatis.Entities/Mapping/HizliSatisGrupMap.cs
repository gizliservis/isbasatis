﻿using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Mapping
{
   public class HizliSatisGrupMap:EntityTypeConfiguration<HizliSatisGrup>
    {
        public HizliSatisGrupMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.GrupAdi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);


            ToTable("HizliSatislarGruplari");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.GrupAdi).HasColumnName("GrupAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

        }
    }
}
