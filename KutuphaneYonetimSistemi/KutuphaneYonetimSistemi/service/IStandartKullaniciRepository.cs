using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IStandartKullaniciRepository
    {
        void Ekle(StandartKullanici kullanici);
        StandartKullanici Getir(int id);
        void Guncelle(StandartKullanici kullanici);
        void Sil(int id);
        IEnumerable<StandartKullanici> TumunuGetir();
    }
}
