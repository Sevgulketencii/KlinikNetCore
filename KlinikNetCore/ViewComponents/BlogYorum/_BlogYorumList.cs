using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.BlogYorum
{
    public class _BlogYorumList : ViewComponent
    {
        YorumManager list = new YorumManager(new EfYorumDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.BlogYorum(ViewBag.id);
            return View(veri);
        }
    }
}
