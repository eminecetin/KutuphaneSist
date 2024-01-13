using KutuphaneYonetimSistemi.database;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminGirisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAdi = AdminAdtext.Text;
                string sifre = AdminSifretext.Text;

                using (var context = new KutuphaneYonetimSistemiContext())
                {
                    var yonetici = context.Yoneticiler
                                          .FirstOrDefault(y => y.KullaniciAdi == kullaniciAdi && y.Sifre == sifre);

                    if (yonetici != null)
                    {
                        YoneticiPanelFormu yoneticiPanelFormu = new YoneticiPanelFormu();
                        yoneticiPanelFormu.Show();
                        this.Hide(); // Opsiyonel: Ana formu gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirirsKayıtIslemleri girisKayitFormu = new GirirsKayıtIslemleri();
            girisKayitFormu.Show();
        }

        private void btnGenelKullaniciAra_Click(object sender, EventArgs e)
        {
            var filmAdi = txtFilmAdiGenelKullanici.Text;
            var yonetmen = txtYonetmenGenelKullanici.Text;
            var tur = txtTurGenelKullanici.Text;

            using (var context = new KutuphaneYonetimSistemiContext())
            {
                var sorguSonucu = context.Filmler.Where(f =>
                    (string.IsNullOrEmpty(filmAdi) || f.Ad.Contains(filmAdi)) &&
                    (string.IsNullOrEmpty(yonetmen) || f.Yonetmen.Contains(yonetmen)) &&
                    (string.IsNullOrEmpty(tur) || f.Tur.Contains(tur)))
                    .ToList();

                // ListBox'a sonuçları ekleme
                filmSonuclariGenelKullanici.Items.Clear();
                foreach (var film in sorguSonucu)
                {
                    string filmBilgisi = $"Ad: {film.Ad}, Yönetmen: {film.Yonetmen}, Tür: {film.Tur}, Yayın Yılı: {film.YayinYili.Year}";
                    filmSonuclariGenelKullanici.Items.Add(filmBilgisi);
                }
            }
        }

        private void btnKullaniciIstatistikGoruntule_Click(object sender, EventArgs e)
        {

        }
    }
}
