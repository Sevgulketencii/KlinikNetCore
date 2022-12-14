using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bloglist = new BlogManager(new EfBlogDal());
        YorumManager yorumlist = new YorumManager(new EfYorumDal());
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetay(int id)
        {
            var veri=bloglist.IdyeGoreListele(id);
            ViewBag.id = id;
            return View(veri);
        }

        [HttpPost]
        public IActionResult BlogYorum(Yorum yeniyorum)
        {
            yorumlist.ekle(yeniyorum);

            return RedirectToAction("Blog", "Blog");
        }
    }
}
