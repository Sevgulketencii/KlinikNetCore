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
    public class HakkimizdaManager : IHakkindaService
    {
        IHakkindaDal hakkinda;
        public HakkimizdaManager(IHakkindaDal veri)
        {
            hakkinda = veri;
        }

        public void ekle(Hakkinda eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Hakkinda güncellenen)
        {
            throw new NotImplementedException();
        }

        public List<Hakkinda> HakkindaListele()
        {
            return hakkinda.HakkindaListele();
        }

        public Hakkinda IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkinda> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Hakkinda silinen)
        {
            throw new NotImplementedException();
        }
    }
}
