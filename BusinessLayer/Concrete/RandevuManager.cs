using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RandevuManager : IRandevuService
    {
        IRandevuDal randevu;
        public RandevuManager(IRandevuDal veri)
        {
            randevu = veri;
        }

        public void ekle(Randevu eklenen)
        {
            randevu.Ekle(eklenen);
        }

        public void güncelle(Randevu güncellenen)
        {
            throw new NotImplementedException();
        }

        public Randevu IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Randevu> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Randevu silinen)
        {
            throw new NotImplementedException();
        }
    }
}
