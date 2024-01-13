using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.database;
using KutuphaneYonetimSistemi.service.serviceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class PreminiumKullaniciFormu : Form
    {
        private int kullaniciId; // Kullanıcı ID'sini tutmak için değişken

        public PreminiumKullaniciFormu(int id)
        {
            InitializeComponent();
            kullaniciId = id; // Giriş yapan kullanıcının ID'sini al
        }

        private void btnFilmEklePremium_Click(object sender, EventArgs e)
        {
            string filmAdi = txtPremiumFilmAdi.Text;
            string yonetmen = txtPremiumYonetmen.Text;

            using (var context = new KutuphaneYonetimSistemiContext())
            {
                var eklenecekFilm = context.Filmler.FirstOrDefault(f => f.Ad == filmAdi && f.Yonetmen == yonetmen);
                if (eklenecekFilm != null)
                {
                    var kullanici = context.PremiumKullanicilar.Find(kullaniciId);
                    kullanici.filmListesi.Add(eklenecekFilm);
                    context.SaveChanges();
                    MessageBox.Show("Film izleme listesine eklendi.");
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            }
        }

        private void btnFilmCikarPremium_Click(object sender, EventArgs e)
        {
            string filmAdi = txtPremiumFilmAdi.Text;
            string yonetmen = txtPremiumYonetmen.Text;

            try
            {
                using (var context = new KutuphaneYonetimSistemiContext())
                {
                    var kullanici = context.PremiumKullanicilar.Find(kullaniciId);
                    var film = context.Filmler.FirstOrDefault(f => f.Ad == filmAdi && f.Yonetmen == yonetmen);

                    if (film != null && kullanici.filmListesi.Contains(film))
                    {
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

        private void btnKullaniciBilgiGoruntule_Click(object sender, EventArgs e)
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

        private void btnFilmDegerlendir_Click(object sender, EventArgs e)
        {
            string filmAdi = txtPremiumDegFilmAdi.Text;
            string yonetmen = txtPremiumDegYonetmen.Text;
            double degerlendirmePuani;

            if (!double.TryParse(txtPremiumDegerlendirmePuani.Text, out degerlendirmePuani) || degerlendirmePuani < 1 || degerlendirmePuani > 5)
            {
                MessageBox.Show("Lütfen geçerli bir puan giriniz (1-5 arası).");
                return;
            }

            using (var context = new KutuphaneYonetimSistemiContext())
            {
                var film = context.Filmler.FirstOrDefault(f => f.Ad == filmAdi && f.Yonetmen == yonetmen);

                if (film != null)
                {
                    film.Puan = degerlendirmePuani;
                    context.SaveChanges();
                    MessageBox.Show("Film değerlendirmesi başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            }
        }

        private void btnPremiumFilmGoruntule_Click(object sender, EventArgs e)
        {
            filmListem.Items.Clear(); // ListBox'u temizle

            FilmServiceImpl filmService = new FilmServiceImpl();
            var filmler = filmService.TumunuGetir(); // Tüm filmleri al

            foreach (var film in filmler)
            {
                // Film bilgilerini ekle (örneğin, adı ve yönetmeni)
                filmListem.Items.Add($"{film.Ad} - {film.Yonetmen}");
            }
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {

        }
    }
}
