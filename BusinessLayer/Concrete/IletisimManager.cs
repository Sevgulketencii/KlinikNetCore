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
    public class IletisimManager : IIletisimService
    {
        IIletisimDal ıletisim;
        public IletisimManager(IIletisimDal veri)
        {
            ıletisim = veri;
        }
        public void ekle(Iletisim eklenen)
        {
            ıletisim.Ekle(eklenen);
        }

        public void güncelle(Iletisim güncellenen)
        {
            throw new NotImplementedException();
        }

        public Iletisim IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Iletisim> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Iletisim silinen)
        {
            throw new NotImplementedException();
        }
    }
}
