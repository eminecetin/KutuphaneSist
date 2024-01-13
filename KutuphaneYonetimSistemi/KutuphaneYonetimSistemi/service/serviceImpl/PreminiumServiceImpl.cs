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
    public class PreminiumServiceImpl : IPreminiumKullaniciRepository
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public void Ekle(PremiumKullanici kullanici)
        {
            context.PremiumKullanicilar.Add(kullanici);
            context.SaveChanges();
        }

        public PremiumKullanici Getir(int id)
        {
            return context.PremiumKullanicilar.FirstOrDefault(k => k.KullaniciId == id);
        }

        public void Guncelle(PremiumKullanici kullanici)
        {
            context.Entry(kullanici).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Sil(int id)
        {
            var kullanici = context.PremiumKullanicilar.Find(id);
            if (kullanici != null)
            {
                context.PremiumKullanicilar.Remove(kullanici);
                context.SaveChanges();
            }
        }

        public IEnumerable<PremiumKullanici> TumunuGetir()
        {
            return context.PremiumKullanicilar.ToList();
        }
    }
}
