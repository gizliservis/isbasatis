using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Mapping;
using Isbasatis.Entities.Tables;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Context
{
   public class IsbaSqlLiteContext:DbContext
    {
        private static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        public IsbaSqlLiteContext() :
          base(new SqliteConnection()
          {
              ConnectionString = new SqliteConnectionStringBuilder() { DataSource = projectDirectory + @"\isba.MODEL\Db\isba.s3db", ForeignKeys = true }.ConnectionString
          }, true)
        {
        }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> hizliSatisGruplari { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod> Kodlar { get; set; }
        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<BankaHareket> BankaHareketleri { get; set; }
        public DbSet<SirketBilgi> SirketBilgileri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());
            modelBuilder.Configurations.Add(new IndirimMap());
            modelBuilder.Configurations.Add(new HizliSatisMap());
            modelBuilder.Configurations.Add(new HizliSatisGrupMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new KodMap());
            modelBuilder.Configurations.Add(new BankaMap());
            modelBuilder.Configurations.Add(new BankaHareketMap());
            modelBuilder.Configurations.Add(new SirketBilgiMap());
        }
    }
}
