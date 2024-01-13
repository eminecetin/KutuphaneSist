using KutuphaneYonetimSistemi.abstractt;
using KutuphaneYonetimSistemi.database;
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
    public partial class GirirsKayıtIslemleri : Form
    {
        public GirirsKayıtIslemleri()
        {
            InitializeComponent();
        }
        private KullaniciServiceImpl kullaniciService = new KullaniciServiceImpl();

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            try { 
            string ad = txtKayitAd.Text;
            string soyad = txtKayitSoyad.Text;
            string tc = txtKayitTC.Text;
            DateTime dogumTarihi = DateTime.Parse(txtKayitDTarih.Text);
            string cinsiyet = txtKayitCinsiyet.Text;
            string uyelikTuru = txtKayitUyelikTuru.Text;
            string kullaniciAdi = txtGirisKullaniciAdi.Text;
            string sifre = txtKayitSifre.Text;

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
                    UyelikTuru=uyelikTuru,
                    KullaniciAdi=kullaniciAdi,
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

        private void btnKullaniciGiriş_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtGirisKullaniciAdi.Text;
            string sifre = txtGirisSifre.Text;

            try
            {
                using (KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext())
                {
                    var kullanici = context.Kullanicilar
                                           .FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

                    if (kullanici != null)
                    {
                        if (kullanici.UyelikTuru == "Standart")
                        {
                            int girisYapanKullaniciId = kullanici.KullaniciId;
                            StandartKullaniciFormu standartForm = new StandartKullaniciFormu(girisYapanKullaniciId);
                            standartForm.Show();
                        }
                        else if (kullanici.UyelikTuru == "Premium")
                        {
                            int girisYapanKullaniciId = kullanici.KullaniciId;
                            PreminiumKullaniciFormu premiumForm = new PreminiumKullaniciFormu(girisYapanKullaniciId);
                            premiumForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


    }
}
