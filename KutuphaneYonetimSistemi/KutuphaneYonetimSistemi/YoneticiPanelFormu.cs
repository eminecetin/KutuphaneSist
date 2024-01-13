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
    public partial class YoneticiPanelFormu : Form
    {
        public YoneticiPanelFormu()
        {
            InitializeComponent();
        }

        private void btnFilmEkleYonetici_Click(object sender, EventArgs e)
        {
            Film yeniFilm = new Film
            {
                Ad = txtFimlAdiYonetici.Text,
                Yonetmen = txtYonetmenYonetici.Text,
                Oyuncular=txtOyuncuYonetici.Text,
                Tur = txtTurYobetici.Text,
                YayinYili = DateTime.Parse(txtYayinYiliYonetici.Text), // Tarih formatına dikkat edin
                Puan = double.Parse(txtDegerlendirmeYonetici.Text) // Puanı doğru şekilde parse edin
            };

            // Film ekleme işlemi için ilgili servis metodu
            // Örneğin: filmService.Ekle(yeniFilm);
            FilmServiceImpl filmService= new FilmServiceImpl();
            filmService.Ekle(yeniFilm);

            MessageBox.Show("Film başarıyla eklendi.");
        }
    }
}
