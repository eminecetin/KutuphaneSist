using KutuphaneYonetimSistemi.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service.serviceImpl
{
    internal class FilmIstatistikleriServiceImpl : IFilmIstatistikleri
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public IEnumerable<string> GetMostReviewedGenres()
        {
            return context.Filmler
                         .GroupBy(f => f.Tur)
                         .OrderByDescending(g => g.Count())
                         .Select(g => g.Key)
                         .ToList();
        }

        public IEnumerable<Film> GetTopRatedFilms(int count)
        {
            return context.Filmler.OrderByDescending(f => f.Puan).Take(count).ToList();
        }

    }
}
