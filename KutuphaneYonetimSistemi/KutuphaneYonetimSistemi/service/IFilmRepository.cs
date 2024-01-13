using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IFilmRepository
    {
        void Ekle(Film film);
        void Guncelle(Film film);
        Film Getir(int id);
        IEnumerable<Film> TumunuGetir();
        void Sil(int id);

        IEnumerable<Film> AraFilmAdi(string ad);
        IEnumerable<Film> AraYonetmen(string yonetmen);
        IEnumerable<Film> AraTur(string tur)
  ;  }
}
