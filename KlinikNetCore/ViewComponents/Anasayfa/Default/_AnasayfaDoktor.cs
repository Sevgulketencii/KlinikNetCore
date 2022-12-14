using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Anasayfa.Default
{
    public class _AnasayfaDoktor : ViewComponent
    {
        DoktorlarManager list = new DoktorlarManager(new EfDoktorlarDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.Listele();
            return View(veri);
        }
    }
}
