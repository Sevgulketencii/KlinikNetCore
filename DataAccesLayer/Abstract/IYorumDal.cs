using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IYorumDal:IGenericDal<Yorum>
    {
        public List<Yorum> BlogYorumList(Expression<Func<Yorum,bool>>Filtre);
    }
}
