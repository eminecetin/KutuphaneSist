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
    public class StandartKullaniciServiceImpl : IStandartKullaniciRepository
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public void Ekle(StandartKullanici kullanici)
        {
            context.StandartKullanicilar.Add(kullanici);
            context.SaveChanges();
        }

        public StandartKullanici Getir(int id)
        {
            return context.StandartKullanicilar.FirstOrDefault(k => k.KullaniciId == id);
        }

        public void Guncelle(StandartKullanici kullanici)
        {
            context.Entry(kullanici).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Sil(int id)
        {
            var kullanici = context.StandartKullanicilar.Find(id);
            if (kullanici != null)
            {
                context.StandartKullanicilar.Remove(kullanici);
                context.SaveChanges();
            }
        }

        public IEnumerable<StandartKullanici> TumunuGetir()
        {
            return context.StandartKullanicilar.ToList();
        }
    }
}
