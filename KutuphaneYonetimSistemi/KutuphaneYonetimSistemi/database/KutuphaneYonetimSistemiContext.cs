using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.database
{
    public class KutuphaneYonetimSistemiContext: DbContext
    {
        public KutuphaneYonetimSistemiContext() : base("name=KutuphaneContext")
        {
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<PremiumKullanici> PremiumKullanicilar { get; set; }
        public DbSet<StandartKullanici> StandartKullanicilar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StandartKullanici>().ToTable("StandartKullanicilar");
            modelBuilder.Entity<PremiumKullanici>().ToTable("PremiumKullanicilar");
        }
       


    }
}
