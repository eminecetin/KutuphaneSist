using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IYorumRepository
    {
        void Ekle(Yorum yorum);
        void Guncelle(Yorum yorum);
        Yorum Getir(int id);
        IEnumerable<Yorum> TumunuGetir();
        void Sil(int id);
    }
}
