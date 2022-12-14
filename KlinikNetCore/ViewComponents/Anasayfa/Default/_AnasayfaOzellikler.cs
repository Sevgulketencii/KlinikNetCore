using BusinessLayer.Concrete;
using DataAccesLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Default
{
    public class _AnasayfaOzellikler : ViewComponent
    {
        AnasayfaManager list = new AnasayfaManager(new EfAnasayfaDal());
        public IViewComponentResult Invoke()
        {
            var veriler = list.özelListe();
            return View(veriler);
        }
    }
}
