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
    public class AnasayfaManager : IAnasayfaService
    {
        IAnasayfaDal anasayfa;

        public AnasayfaManager(IAnasayfaDal anasayfaDal)
        {
            anasayfa = anasayfaDal;
        }

        public void ekle(Anasayfa eklenen)
        {
            anasayfa.Ekle(eklenen);
        }

        public void güncelle(Anasayfa güncellenen)
        {
            anasayfa.Güncelle(güncellenen);
        }

        public Anasayfa IdyeGoreListele(int id)
        {
            throw new NotImplementedException();
        }

        public List<Anasayfa> Listele()
        {
            return anasayfa.Listele();
        }

        public void sil(Anasayfa silinen)
        {
            anasayfa.Sil(silinen);
        }

        public List<Anasayfa> özelListe()
        {
            return anasayfa.Ozellik();
        }
    }
}
