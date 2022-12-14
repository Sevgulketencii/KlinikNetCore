using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.ViewComponents.Anasayfa.Default
{
    public class _AnasayfaRandevu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
