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
    public class EfHakkindaDal : GenericRepository<Hakkinda>, IHakkindaDal
    {
        Context baglan = new Context();
        public List<Hakkinda> HakkindaListele()
        {
            return baglan.HakkindaDbSet.OrderByDescending(x => x.Statu==true).Take(1).ToList();
        }
    }
}
