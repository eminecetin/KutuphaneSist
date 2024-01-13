using KutuphaneYonetimSistemi.abstractt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.model
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public string Icerik { get; set; }
        public DateTime YorumTarihi { get; set; }

        // Film-Yorum ilişkisi
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

        // Kullanıcı-Yorum ilişkisi
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
