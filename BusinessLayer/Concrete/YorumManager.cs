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
    public class YorumManager : IYorumService
    {
        IYorumDal yorum;

        public YorumManager(IYorumDal veri)
        {
            yorum = veri;
        }

        public List<Yorum> BlogYorum(int id)
        {
            return yorum.BlogYorumList(x => x.BlogId == id);
        }

        public void ekle(Yorum eklenen)
        {
            yorum.Ekle(eklenen);
        }

        public void güncelle(Yorum güncellenen)
        {
            throw new NotImplementedException();
        }

        public Yorum IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yorum> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Yorum silinen)
        {
            throw new NotImplementedException();
        }
    }
}
