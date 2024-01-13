using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.database;
using KutuphaneYonetimSistemi.service.serviceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class StandartKullaniciFormu : Form
    {
        private int kullaniciId; // Kullanıcı ID'sini tutmak için değişken

        public StandartKullaniciFormu(int id)
        {
            InitializeComponent();
            kullaniciId = id; // Giriş yapan kullanıcının ID'sini al
        }

        private void btnFilmGoruntuleStandart_Click(object sender, EventArgs e)
        {
            filmListesi.Items.Clear(); // ListBox'u temizle

            FilmServiceImpl filmService = new FilmServiceImpl();
            var filmler = filmService.TumunuGetir(); // Tüm filmleri al

            foreach (var film in filmler)
            {
                // Film bilgilerini ekle (örneğin, adı ve yönetmeni)
                filmListesi.Items.Add($"{film.Ad} - {film.Yonetmen}");
            }
        }

        private void btnStandartBilgilerimiGoruntule_Click(object sender, EventArgs e)
        {
            Bilgilerim.Items.Clear(); // ListBox'u temizle

            KullaniciServiceImpl kullaniciService = new KullaniciServiceImpl();
            var kullanici = kullaniciService.GetirKullanici(kullaniciId); // Oturum açan kullanıcının bilgilerini al

            // Kullanıcı bilgilerini ListBox'a ekle
            Bilgilerim.Items.Add("Ad: " + kullanici.Ad);
            Bilgilerim.Items.Add("Soyad: " + kullanici.Soyad);
            Bilgilerim.Items.Add("TC: " + kullanici.TC);
            Bilgilerim.Items.Add("Doğum Tarihi: " + kullanici.DogumTarihi.ToShortDateString());
            Bilgilerim.Items.Add("Cinsiyet: " + kullanici.Cinsiyet);
            Bilgilerim.Items.Add("Üyelik Türü: " + kullanici.UyelikTuru);
        }

        private void btnFilmEkleStandart_Click(object sender, EventArgs e)
        {
            KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

            string filmAdi = textFilmAdiStandart.Text;
            string yonetmen = textYonetmenStandart.Text;

            var eklenecekFilm = context.Filmler.FirstOrDefault(f => f.Ad == filmAdi && f.Yonetmen == yonetmen);
            if (eklenecekFilm != null)
            {
                // Örnek kullanıcı
                var kullanici = context.StandartKullanicilar.Find(kullaniciId); // Burada 'kullaniciId' değeri nasıl elde edildiğine bağlı
                kullanici.filmListesi.Add(eklenecekFilm);
                context.SaveChanges();
                MessageBox.Show("Film izleme listesine eklendi.");
            }
            else
            {
                MessageBox.Show("Film bulunamadı.");
            }
        }

        private void btnFilmCikarStandart_Click(object sender, EventArgs e)
        {
            string filmAdi = textFilmAdiStandart.Text;
            string yonetmen = textYonetmenStandart.Text;

            try
            {
                using (var context = new KutuphaneYonetimSistemiContext())
                {
                    // Kullanıcıyı ve filmi bul
                    var kullanici = context.StandartKullanicilar.Find(kullaniciId);
                    var film = context.Filmler.FirstOrDefault(f => f.Ad == filmAdi && f.Yonetmen == yonetmen);

                    if (film != null && kullanici != null && kullanici.filmListesi.Contains(film))
                    {
                        // Film, kullanıcının izleme listesinden çıkarılır
                        kullanici.filmListesi.Remove(film);
                        context.SaveChanges();
                        MessageBox.Show("Film izleme listenizden çıkarıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Film bulunamadı veya izleme listenizde değil.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {

        }
    }
}
