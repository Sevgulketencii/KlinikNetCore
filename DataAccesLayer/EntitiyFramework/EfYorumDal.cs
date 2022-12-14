using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntitiyFramework
{
    public class EfYorumDal : GenericRepository<Yorum>, IYorumDal
    {
        Context baglan=new Context();

        public List<Yorum> BlogYorumList(Expression<Func<Yorum, bool>> Filtre)
        {
            return baglan.YorumDbSet.Where(Filtre).ToList();
        }
    }
}
