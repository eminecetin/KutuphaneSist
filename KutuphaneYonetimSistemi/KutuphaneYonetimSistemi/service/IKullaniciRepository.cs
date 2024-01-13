using KutuphaneYonetimSistemi.abstractt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service
{
    public interface IKullaniciRepository
    {
       
            void EkleKullanici(Kullanici kullanici, string kullaniciTuru);
            Kullanici GetirKullanici(int id);
            void GuncelleKullanici(Kullanici kullanici);
            void SilKullanici(int id);
            IEnumerable<Kullanici> TumKullanicilariGetir();
        

    }
}
