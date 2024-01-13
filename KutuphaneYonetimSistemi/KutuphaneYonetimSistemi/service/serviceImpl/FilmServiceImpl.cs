using KutuphaneYonetimSistemi.database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service.serviceImpl
{
    public class FilmServiceImpl : IFilmRepository
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public IEnumerable<Film> AraFilmAdi(string ad)
        {
            return context.Filmler.Where(f => f.Ad.Contains(ad)).ToList();
        }


        public IEnumerable<Film> AraTur(string tur)
        {
            return context.Filmler.Where(f => f.Tur.Contains(tur)).ToList();
        }


        public IEnumerable<Film> AraYonetmen(string yonetmen)
        {
            return context.Filmler.Where(f => f.Yonetmen.Contains(yonetmen)).ToList();
        }


        public void Ekle(Film film)
        {
            context.Filmler.Add(film);
            context.SaveChanges();
        }

        public Film Getir(int id)
        {
            return context.Filmler.FirstOrDefault(f => f.FilmId == id);
        }

        public void Guncelle(Film film)
        {
            context.Entry(film).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Sil(int id)
        {
            var film = context.Filmler.Find(id);
            if (film != null)
            {
                context.Filmler.Remove(film);
                context.SaveChanges();
            }
        }

        public IEnumerable<Film> TumunuGetir()
        {
            return context.Filmler.ToList();
        }
    }
}
