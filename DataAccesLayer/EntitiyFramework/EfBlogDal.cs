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
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        Context baglan = new Context();
        public List<Blog> AnasayfaBlog()
        {
            return baglan.BlogDbSet.OrderByDescending(x => x.BlogId).Take(3).ToList();
        }

        public List<Blog> SonBloglar()
        {
            return baglan.BlogDbSet.OrderByDescending(x => x.BlogId).Take(4).ToList();
        }
    }
}
