using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntitiyFramework
{
    public class EfAnasayfaDal : GenericRepository<Anasayfa>, IAnasayfaDal
    {
        Context baglan = new Context();
        public List<Anasayfa> Ozellik()
        {
            return baglan.AnasayfaDbSet.OrderByDescending(x=>x.AnasayfaId).Take(1).ToList();
        }
    }
}
