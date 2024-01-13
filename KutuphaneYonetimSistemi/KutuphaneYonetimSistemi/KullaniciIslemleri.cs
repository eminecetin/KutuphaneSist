using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.model;
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
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;
            string soyad = txtKullaniciSoyad.Text;
            string tc = txtKullaniciTC.Text;
            DateTime dogumTarihi = DateTime.Parse(txtKullaniciDTarih.Text);
            string cinsiyet = txtKullaniciCinsiyet.Text;
            string uyelikTuru = txtKullaniciUyelikTur.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Kullanici yeniKullanici;
            if (uyelikTuru == "Standart")
            {
                yeniKullanici = new StandartKullanici
                {
                    Ad = ad,
                    Soyad = soyad,
                    TC = tc,
                    DogumTarihi = dogumTarihi,
                    Cinsiyet = cinsiyet,
                    UyelikTuru = uyelikTuru,
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifre
                };
            }
            else
            {
                yeniKullanici = new PremiumKullanici
                {
                    Ad = ad,
                    Soyad = soyad,
                    TC = tc,
                    DogumTarihi = dogumTarihi,
                    Cinsiyet = cinsiyet,
                    UyelikTuru = uyelikTuru,
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifre
                };
            }

            KullaniciServiceImpl kullaniciService = new KullaniciServiceImpl();
            kullaniciService.EkleKullanici(yeniKullanici, uyelikTuru);

            MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                // Kullanıcı kaydetme işlemi...
            }
            catch (FormatException)
            {
                MessageBox.Show("Doğum tarihi yanlış biçimlendirilmiş. Lütfen doğru bir tarih giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            int kullaniciId = int.Parse(txtKullaniciId.Text);
            string ad = txtAd.Text;
            string soyad = txtKullaniciSoyad.Text;
            string tc = txtKullaniciTC.Text;
            DateTime dogumTarihi = DateTime.Parse(txtKullaniciDTarih.Text);
            string cinsiyet = txtKullaniciCinsiyet.Text;
            string uyelikTuru = txtKullaniciUyelikTur.Text;
            string kullaniciAdi=txtKullaniciAdi.Text;
            string sifre=txtSifre.Text;

            KullaniciServiceImpl kullaniciService = new KullaniciServiceImpl();
            Kullanici kullanici = kullaniciService.GetirKullanici(kullaniciId);

            if (kullanici != null)
            {
                kullanici.Ad = ad;
                kullanici.Soyad = soyad;
                kullanici.TC = tc;
                kullanici.DogumTarihi = dogumTarihi;
                kullanici.Cinsiyet = cinsiyet;
                kullanici.UyelikTuru = uyelikTuru;
                kullanici.KullaniciAdi = kullaniciAdi;
                kullanici.Sifre = sifre;

                kullaniciService.GuncelleKullanici(kullanici);
                MessageBox.Show("Kullanıcı başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void btnKullaniciHesapKapat_Click(object sender, EventArgs e)
        {
            int kullaniciId = int.Parse(txtKullaniciId.Text);

            KullaniciServiceImpl kullaniciService = new KullaniciServiceImpl();
            kullaniciService.SilKullanici(kullaniciId);

            MessageBox.Show("Kullanıcı hesabı başarıyla kapatıldı.");
        }
    }
}
