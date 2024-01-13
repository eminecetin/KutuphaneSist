using KutuphaneYonetimSistemi.abstractt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.model
{
    public class PremiumKullanici:Kullanici
    {
        public PremiumKullanici()
        {
        }

        public PremiumKullanici(Kullanici temelKullanici) {
            this.Ad = temelKullanici.Ad;
            this.Soyad = temelKullanici.Soyad;
            this.TC = temelKullanici.TC;
            this.DogumTarihi = temelKullanici.DogumTarihi;
            this.Cinsiyet = temelKullanici.Cinsiyet;
            this.KullaniciAdi = temelKullanici.KullaniciAdi;
            this.Sifre=temelKullanici.Sifre;
        }
        public decimal UyelikUcreti { get { return 125; } } // %25 artışla hesaplanan ücret

    }
}
