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
    public class RandevuController : Controller
    {
        RandevuManager veri = new RandevuManager(new EfRandevuDal());
        [HttpPost]
        public IActionResult Randevu(Randevu randevu)
        {
            veri.ekle(randevu);
            return RedirectToAction("Index","Home");
        }
    }
}
