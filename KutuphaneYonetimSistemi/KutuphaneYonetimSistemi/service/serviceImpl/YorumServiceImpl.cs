using KutuphaneYonetimSistemi.database;
using KutuphaneYonetimSistemi.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.service.serviceImpl
{
    public class YorumServiceImpl : IYorumRepository
    {
        private KutuphaneYonetimSistemiContext context = new KutuphaneYonetimSistemiContext();

        public void Ekle(Yorum yorum)
        {
            context.Yorumlar.Add(yorum);
            context.SaveChanges();
        }

        public Yorum Getir(int id)
        {
            return context.Yorumlar.FirstOrDefault(y => y.YorumId == id);
        }

        public void Guncelle(Yorum yorum)
        {
            context.Entry(yorum).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Sil(int id)
        {
            var yorum = context.Yorumlar.Find(id);
            if (yorum != null)
            {
                context.Yorumlar.Remove(yorum);
                context.SaveChanges();
            }
        }

        public IEnumerable<Yorum> TumunuGetir()
        {
            return context.Yorumlar.ToList();
        }
    }
}
