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
    public class BlogManager : IBlogService
    {
        IBlogDal blog;
        public BlogManager(IBlogDal veri)
        {
            blog = veri;
        }

        public List<Blog> AnasayfaBlog()
        {
            return blog.AnasayfaBlog();
        }

        public void ekle(Blog eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Blog güncellenen)
        {
            throw new NotImplementedException();
        }

        public Blog IdyeGoreListele(int id)
        {
           return blog.IdGoreListele(id);
        }

        public List<Blog> Listele()
        {
            return blog.Listele();
        }

        public void sil(Blog silinen)
        {
            throw new NotImplementedException();
        }

        public List<Blog> SonBloglar()
        {
            return blog.SonBloglar();
        }
    }
}
