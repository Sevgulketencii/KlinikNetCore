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
    public class DoktorlarManager : IDoktorlarService
    {
        IDoktorlarDal doktor;
        public DoktorlarManager(IDoktorlarDal veri)
        {
            doktor = veri;
        }


        public void ekle(Doktorlar eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Doktorlar güncellenen)
        {
            throw new NotImplementedException();
        }

        public Doktorlar IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Doktorlar> Listele()
        {
            return doktor.Listele();
        }

        public void sil(Doktorlar silinen)
        {
            throw new NotImplementedException();
        }
    }
}
