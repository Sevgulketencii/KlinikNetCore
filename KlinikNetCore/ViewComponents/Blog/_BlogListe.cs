﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Blog
{
    public class _BlogListe : ViewComponent
    {
        BlogManager list = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.Listele();
            return View(veri);
        }
    }
}
