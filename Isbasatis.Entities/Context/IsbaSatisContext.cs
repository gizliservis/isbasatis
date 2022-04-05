using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Isbasatis.Entities.Mapping;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
using Isbasatis.Entities.Migrations;

namespace Isbasatis.Entities.Context
{
    public class IsbaSatisContext:DbContext
    {
        public IsbaSatisContext():base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi) ?? "Bağlantı Yok")
        {
            Database.SetInitializer<IsbaSatisContext>(new MigrateDatabaseToLatestVersion<IsbaSatisContext, Configuration>());
        }
        public IsbaSatisContext(string connString):base(connString)
        {
            Database.SetInitializer<IsbaSatisContext>(new MigrateDatabaseToLatestVersion<IsbaSatisContext, Configuration>());
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
        public DbSet <HizliSatis> HizliSatislar { get; set; }
        public DbSet <HizliSatisGrup> hizliSatisGruplari { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod>Kodlar { get; set; }
        public DbSet<Banka>Bankalar { get; set; }
        public DbSet<BankaHareket>BankaHareketleri { get; set; }


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
        }
    }
}
