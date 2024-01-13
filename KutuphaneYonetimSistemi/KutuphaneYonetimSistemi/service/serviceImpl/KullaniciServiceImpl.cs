using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.database;
using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service.serviceImpl
{
    public class KullaniciServiceImpl : IKullaniciRepository
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public void EkleKullanici(Kullanici kullanici, string kullaniciTuru)
        {
            if (kullaniciTuru == "Standart")
            {
                var standartKullanici = new StandartKullanici()
                {
                    Ad = kullanici.Ad,
                    Soyad = kullanici.Soyad,
                    TC = kullanici.TC,
                    DogumTarihi = kullanici.DogumTarihi,
                    Cinsiyet = kullanici.Cinsiyet,
                    UyelikTuru = kullanici.UyelikTuru,
                    KullaniciAdi = kullanici.KullaniciAdi,
                    Sifre=kullanici.Sifre,
                    // Diğer özellikler
                };
                context.StandartKullanicilar.Add(standartKullanici);
            }
            else if (kullaniciTuru == "Premium")
            {
                var premiumKullanici = new PremiumKullanici()
                {
                    Ad = kullanici.Ad,
                    Soyad = kullanici.Soyad,
                    TC = kullanici.TC,
                    DogumTarihi = kullanici.DogumTarihi,
                    Cinsiyet = kullanici.Cinsiyet,
                    UyelikTuru = kullanici.UyelikTuru,
                    KullaniciAdi = kullanici.KullaniciAdi,
                    Sifre = kullanici.Sifre,
                    // Diğer özellikler
                };
                context.PremiumKullanicilar.Add(premiumKullanici);
            }
            context.SaveChanges();
        }

        public Kullanici GetirKullanici(int id)
        {
            return context.Kullanicilar.FirstOrDefault(k => k.KullaniciId == id);
        }

        public void GuncelleKullanici(Kullanici kullanici)
        {
            context.Entry(kullanici).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void SilKullanici(int id)
        {
            var kullanici = context.Kullanicilar.Find(id);
            if (kullanici != null)
            {
                context.Kullanicilar.Remove(kullanici);
                context.SaveChanges();
            }
        }

        public IEnumerable<Kullanici> TumKullanicilariGetir()
        {
            return context.Kullanicilar.ToList();
        }
    }

}
