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
    public class IletisimController : Controller
    {
        IletisimManager veri = new IletisimManager(new EfIletisimDal());
      
        public IActionResult Iletisim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Iletisim(Iletisim yeniIlet)
        {
            veri.ekle(yeniIlet);
            return RedirectToAction("Iletisim", "Iletisim");
        }
    }
}
