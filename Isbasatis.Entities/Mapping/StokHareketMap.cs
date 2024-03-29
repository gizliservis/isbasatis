﻿using System;
using System.Collections.Generic;
using Isbasatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Mapping
{
    public class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(14);
            this.Property(p => p.FisBaglantiKodu).HasMaxLength(14);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.Miktar).HasPrecision(12,3);
            this.Property(p => p.BirimFiyati).HasPrecision(12,2);
            this.Property(p => p.AlisFiyati).HasPrecision(12,2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12,2);
            this.Property(p => p.AlisFiyati3).HasPrecision(12,2);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.SayimMiktari).HasPrecision(12, 2);
            this.Property(p => p.MevcutStok).HasPrecision(12, 2);
            this.Property(p => p.SeriNo).HasMaxLength(200);
            this.Property(p => p.Aciklama).HasMaxLength(200);



            this.ToTable("StokHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisBaglantiKodu).HasColumnName("FisBaglantiKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokId).HasColumnName("StokId");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.AlisFiyati).HasColumnName("AlisFiyati");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.SayimMiktari).HasColumnName("SayimMiktari");
            this.Property(p => p.MevcutStok).HasColumnName("MevcutStok");
            this.Property(p => p.DepoId).HasColumnName("DepoId");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c => c.Stok).WithMany(c => c.StokHareket).HasForeignKey(c => c.StokId);
            this.HasRequired(c => c.Depo).WithMany(c => c.StokHareket).HasForeignKey(c => c.DepoId);
        }
    }
}
