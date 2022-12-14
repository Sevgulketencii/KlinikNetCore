using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Hakkimizda
{
    public class _Hakkimizda : ViewComponent
    {
        HakkimizdaManager list = new HakkimizdaManager(new EfHakkindaDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.HakkindaListele();
            return View(veri);

        }
    }
}
