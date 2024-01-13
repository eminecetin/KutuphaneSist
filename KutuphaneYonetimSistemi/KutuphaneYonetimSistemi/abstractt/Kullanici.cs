using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.abstractt
{
    public abstract class Kullanici
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string UyelikTuru { get; set; } // "Standart" veya "Premium" gibi
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public List<Film> filmListesi { get; set; }

        protected Kullanici()
        {
            filmListesi = new List<Film>();
        }
    }
}
