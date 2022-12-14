using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Doktorlar
{
    public class _Doktorlar : ViewComponent
    {
        DoktorlarManager list = new DoktorlarManager(new EfDoktorlarDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.Listele();
            return View(veri);
        }
    }
}
