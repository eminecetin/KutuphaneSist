﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IFilmIstatistikleri
    {
        IEnumerable<Film> GetTopRatedFilms(int count);
        IEnumerable<string> GetMostReviewedGenres();
    }
}
