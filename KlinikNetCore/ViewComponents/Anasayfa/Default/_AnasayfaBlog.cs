using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Anasayfa.Default
{
    public class _AnasayfaBlog : ViewComponent
    {
        BlogManager list = new BlogManager(new EfBlogDal());
       
        public IViewComponentResult Invoke()
        {
            var veri = list.AnasayfaBlog();
            return View(veri);
        }
    }
}
