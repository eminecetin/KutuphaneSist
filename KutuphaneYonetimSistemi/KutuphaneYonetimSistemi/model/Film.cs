using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class Film
    {

        public int FilmId { get; set; }
        public string Ad { get; set; }
        public string Yonetmen { get; set; }
        public string Oyuncular { get; set; } // Oyuncuları virgülle ayrılmış string olarak saklamak için
        public DateTime YayinYili { get; set; }
        public string Tur { get; set; }
        public double Puan { get; set; }

        // Film-Yorum ilişkisi: Bir film birden çok yoruma sahip olabilir
        public virtual ICollection<Yorum> Yorumlar { get; set; }

        public Film()
        {
            Yorumlar = new HashSet<Yorum>();
        }
    }
}
