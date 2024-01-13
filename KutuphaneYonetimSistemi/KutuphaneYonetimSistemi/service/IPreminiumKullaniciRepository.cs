using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IPreminiumKullaniciRepository
    {
        void Ekle(PremiumKullanici kullanici);
        PremiumKullanici Getir(int id);
        void Guncelle(PremiumKullanici kullanici);
        void Sil(int id);
        IEnumerable<PremiumKullanici> TumunuGetir();
    }
}
